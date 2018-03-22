using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourSqlLite
{
    class FilieresOperationImpl : IFiliereOperations
    {
        Database database;

        public FilieresOperationImpl()
        {
        }

        public FilieresOperationImpl(Database database)
        {
            this.database = database;
        }

        public int AddFiliere(Filiere f)
        {
            int res=0;
            database.OpenConnection();
            string query = "INSERT INTO filiere (Nom_filiere,Responsable,date_creation) VALUES(@nomFiliere,@responsable,@date_creation)";
            SQLiteCommand command = new SQLiteCommand(query, database.Connection);
            SQLiteParameter p1 = new SQLiteParameter("NomFiliere", f.Nom_filiere);
            SQLiteParameter p2 = new SQLiteParameter("Responsable", f.Responsable);
            SQLiteParameter p3 = new SQLiteParameter("Date_creation", f.Date_creation);
            command.Parameters.Add(p1);
            command.Parameters.Add(p2);
            command.Parameters.Add(p3);
            command.ExecuteNonQuery();

            database.CloseConnection();
            Console.WriteLine("Nombre de lignes ajoutées: {0}", res);
            return res;
        }

        public void DeleteEtudiant(Filiere f)
        {
            throw new NotImplementedException();
        }

        public Filiere findFiliereById(int id_fil)
        {
            database.OpenConnection();
            String query = "SELECT Id_filiere, Nom_filiere, Responsable, date_creation FROM filiere WHERE Id_filiere="+id_fil+";";
            SQLiteCommand command = new SQLiteCommand(query, database.Connection);
            SQLiteDataReader r = command.ExecuteReader();
            if (r.Read()) {
                Filiere f = new Filiere();
                f.Id_filiere = Convert.ToInt32(r["Id_filiere"]);
                f.Nom_filiere = r["Nom_filiere"].ToString();
                f.Responsable = r["Responsable"].ToString();
                f.Date_creation = Convert.ToDateTime(r["date_creation"]);
                return f;
            }

            return null;
        }

        public List<Filiere> getAllFields()
        {
            List<Filiere> list = new List<Filiere>();
            database.OpenConnection();
            String query= "SELECT Id_filiere, Nom_filiere, Responsable, date_creation FROM filiere";
            SQLiteCommand command = new SQLiteCommand(query, database.Connection);
            SQLiteDataReader r =command.ExecuteReader();
            while (r.Read())
            {
                Filiere f=new Filiere();
                f.Id_filiere = Convert.ToInt32(r["Id_filiere"]);
                f.Nom_filiere = r["Nom_filiere"].ToString();
                f.Responsable = r["Responsable"].ToString();
                f.Date_creation = Convert.ToDateTime(r["date_creation"]);
                list.Add(f);
            }

            return list;
        }

        public void UpdateEtudiant(Filiere f)
        {
            throw new NotImplementedException();
        }
    }
}
