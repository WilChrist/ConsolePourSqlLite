using System.Data.SQLite;
using System.IO;
namespace ConsolePourSqlLite
{
    class Database
    {
        SQLiteConnection connection;

        public Database()
        {
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
    }
}
