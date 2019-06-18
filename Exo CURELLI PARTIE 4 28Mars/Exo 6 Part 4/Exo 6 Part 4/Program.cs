using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Decembre" };
            // Initialisation de mon tableau avec les differents mois de l'année

            foreach (string month in months) // Boucle qui s'executera tant que tout les caractères présents dans mon tableau ne seront pas affichés
            {
                Console.WriteLine(month);
            }


        }
    }
}
