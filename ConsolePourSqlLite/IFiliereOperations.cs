using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourSqlLite
{
    public interface IFiliereOperations
    {
        int AddFiliere(Filiere f);
        Filiere findFiliereById(int id_fil);
        List<Filiere> getAllFields();
        void UpdateEtudiant(Filiere f);
        void DeleteEtudiant(Filiere f);
    }
}
