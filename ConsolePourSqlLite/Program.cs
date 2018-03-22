
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            database = new Database();
            etudiantOperation = new EtudiantOperationImpl(database);
            Etudiant etudiant = new Etudiant(1, "Nzesseu", "Willy", "Wad El-Basha", "0635348819", "myBeautifulFace.jpg", 'M', DateTime.Now);
            etudiantOperation.CreateEtudiant(etudiant);
            Console.Read();
            
        }
        
    }
}
