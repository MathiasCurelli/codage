using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int numberToFind = new Random().Next(1, 51); // Permet de générer un nombre aléatoire compris entre 1 et 50 
                int tryNumbers = 0; // Variable permettant de calculer le nombre de coups réalisés pour obtenir le bon chiffre
                bool find = false; // Permet de créer une boucle "tant que le résultat est faux, le jeu continue.cela stock la valeur "faux"

                Console.WriteLine("Bonjour, et bienvenue sur Le Juste Prix ONLINE, veuillez s'il vous plaît saisir un nombre compris entre 1 et 50 (inclu)");

                while (!find)
                {
                    string saisie = Console.ReadLine(); 
                    int userNumber;
                    if (int.TryParse(saisie, out userNumber)) // Si la saisie a bien été convertie et est acceptable
                    {
                        if (userNumber == numberToFind)

                        { find = true;

                         Console.WriteLine("Vous avez trouvé en " + tryNumbers + " coup(s), félicitation !");

                        }



                      else
                      {
                           if (userNumber < numberToFind)
                                Console.WriteLine("Non, c'est plus grand !! ");
                           else
                                Console.WriteLine("Ah, non ! C'est plus petit ...");
                      }
                        tryNumbers++;
                    }


                      else
                        Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                }
                
            }

        }
            }
        }
    

       



    


    

