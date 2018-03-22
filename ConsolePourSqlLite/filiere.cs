using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourSqlLite
{
    public class Filiere
    {
        private int id_filiere;
        private String nom_filiere, responsable;
        private DateTime date_creation;

        public Filiere()
        {
        }

        public Filiere( string nom_filiere, string responsable, DateTime date_creation)
        {
            this.nom_filiere = nom_filiere;
            this.responsable = responsable;
            this.date_creation = date_creation;
        }

        public Filiere(int id_filiere, string nom_filiere, string responsable, DateTime date_creation)
        {
            this.id_filiere = id_filiere;
            this.nom_filiere = nom_filiere;
            this.responsable = responsable;
            this.date_creation = date_creation;
        }

        public int Id_filiere { get => id_filiere; set => id_filiere = value; }
        public string Nom_filiere { get => nom_filiere; set => nom_filiere = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public DateTime Date_creation { get => date_creation; set => date_creation = value; }
    }
}
