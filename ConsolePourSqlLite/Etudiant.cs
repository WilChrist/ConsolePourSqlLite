using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourSqlLite
{
    class Etudiant
    {
        Int32 cne;
        Int32 id_fil;
        string nom;
        string prenom;
        string adresse;
        string telephone;
        string image;
        char sexe;
        DateTime date_naissance;

        public Etudiant(int id_fil, string nom, string prenom, string adresse, string telephone, string image,char sexe, DateTime date_naissance)
        {
            this.id_fil = id_fil;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.image = image;
            this.Sexe = sexe;
            this.date_naissance = date_naissance;
        }
        public Etudiant()
        {

        }

        public int Cne { get => cne; }
        public int Id_fil { get => id_fil; set => id_fil = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Image { get => image; set => image = value; }
        public DateTime Date_naissance { get => date_naissance.Date; set => date_naissance = value; }
        public char Sexe { get => sexe; set => sexe = value; }
    }
}
