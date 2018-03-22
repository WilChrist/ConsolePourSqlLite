using System.Data.SQLite;
using System.IO;
namespace ConsolePourSqlLite
{
    class Database
    {
        SQLiteConnection connection;

        public Database()
        {
            // name of the database to use
            Connection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists("./database.sqlite3"))
            {
                System.Console.WriteLine("Création de la Base de Données...");
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("Base de Données créée!");
            }
            else
            {
                System.Console.WriteLine("Base de Données déjà créée!");
            }
            
        }

        public SQLiteConnection Connection { get => connection; set => connection = value; }
        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
