using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_8_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pairs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; // Création de notre tableau avec notre variable "pairs" et ses différentes valeurs

            
            foreach (int numbers in pairs) // On pose une variable appelée "i" qui contiendra des entiers, allant de 0 à 20, dans une boucle qui sera arrêtée une fois atteint les 20 répétitions
            {
              if (numbers % 2 == 0)  

                Console.WriteLine(numbers); // Affichage des chiffres pairs UNIQUEMENT dans la console
            }
        }
    }
}

