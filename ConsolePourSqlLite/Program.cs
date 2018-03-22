
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolePourSqlLite
{
    class Program
    {
        static Database database;
        static EtudiantOperationImpl etudiantOperation;
        static FilieresOperationImpl filieresOperation;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            database = new Database();
            /* etudiantOperation = new EtudiantOperationImpl(database);
             Etudiant etudiant = new Etudiant(1, "Nzesseu", "Willy", "Wad El-Basha", "0635348819", "myBeautifulFace.jpg", 'M', DateTime.Now);
             etudiantOperation.CreateEtudiant(etudiant);*/
            filieresOperation = new FilieresOperationImpl(database);
            Filiere f = new Filiere("filiere 3", "responsable1", DateTime.Now);
          //  int i=filieresOperation.AddFiliere(f);
            foreach(Filiere a in filieresOperation.getAllFields())
            {
                Console.WriteLine(a.Nom_filiere);
            }
            Console.WriteLine(filieresOperation.findFiliereById(1).Nom_filiere);
            Console.ReadKey();


            
        }
        
    }
}
