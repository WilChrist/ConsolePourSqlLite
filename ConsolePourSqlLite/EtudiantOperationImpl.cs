using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourSqlLite
{
    class EtudiantOperationImpl : IEtudiantOperation
    {
        Database database;
        public EtudiantOperationImpl()
        {
            database = new Database();
        }
        public EtudiantOperationImpl(Database database)
        {
            this.database = database;
        }
        public int CreateEtudiant(Etudiant etudiant)
        {
            int res;
            string query = "INSERT INTO etudiant (id_fil,nom,prenom,adresse,telephone,image,sexe,date_naissance) VALUES(@id_fil,@nom,@prenom,@adresse,@telephone,@image,@sexe,@date_naissance)";
            SQLiteCommand command = new SQLiteCommand(query, database.Connection);
            database.OpenConnection();
            command.Parameters.AddWithValue("@id_fil", etudiant.Id_fil);
            command.Parameters.AddWithValue("@nom", etudiant.Nom);
            command.Parameters.AddWithValue("@prenom", etudiant.Prenom);
            command.Parameters.AddWithValue("@adresse", etudiant.Adresse);
            command.Parameters.AddWithValue("@telephone", etudiant.Telephone);
            command.Parameters.AddWithValue("@image", etudiant.Image);
            command.Parameters.AddWithValue("@sexe", etudiant.Sexe);
            command.Parameters.AddWithValue("@date_naissance", etudiant.Date_naissance);//etudiant.Date_naissance.ToString("dd/MM/yyyy").Replace('-', '/')
            Console.WriteLine(etudiant.Date_naissance);
            res = command.ExecuteNonQuery();
            database.CloseConnection();
            Console.WriteLine("Nombre de lignes ajoutées: {0}",res);
            return res;
        }
        public Etudiant ReadEtudiant(int cne)
        {
            return new Etudiant();
        }
        public List<Etudiant> ReadEtudiants()
        {
            return new List<Etudiant>();
        }
        public void UpdateEtudiant(Etudiant etudiant)
        {

        }
        public void DeleteEtudiant(Etudiant etudiant)
        {

        }
    }
}
