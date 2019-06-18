using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Program
    {
        static void Main(string[] args)
        {

         double poids;
         double taille;
         double imc;

            
         Console.WriteLine("Bonjour et bienvenue sur CalculTonIMC.com !");
         Console.WriteLine(); 

         Console.WriteLine("votre taille en m ? ");
         taille = double.Parse(Console.ReadLine()); // on demande d'entrer la taille 
         taille = Math.Pow(taille, 2);  //calcule de la taille au carré

            


        if (taille < 0.00 || taille > 3.00)
        { Console.WriteLine("Erreur de saisie sur la taille, veuillez réesayer."); }

                   
        else
        {

                Console.WriteLine("Votre poids en kg ? ");
                poids = double.Parse(Console.ReadLine()); // On demande d'entrer le poid


                   if (poids > 250)
                   { Console.WriteLine("Erreur de saisie sur le poid, veuillez réesayer."); }

                      else
                      {
              

                    imc = Math.Round(poids / taille, 2);  //calcule imc à 2 chiffres


                    if (imc >= 40)
                    { Console.WriteLine("\n\n Vous êtes en obésité morbide, attention à votre santé !\n"); }

                    else if (imc > 35 && imc < 40)
                    { Console.WriteLine("\n\n Vous êtes en obésité sévère, vous devriez vous mettre au sport!"); }

                    else if (imc > 30 && imc < 35)
                    { Console.WriteLine("\n\n Vous êtes en obésité modérée, au régime !"); }

                    else if (imc > 25 && imc < 30)
                    { Console.WriteLine("\n\n Vous etes en surpoid, attention aux Cheat-meals !"); }

                    else if (imc > 18.5 && imc < 25)
                    { Console.WriteLine("\n\n Vous etes normal, bravo."); }

                    else if (imc > 16.5 && imc < 18.5)
                    { Console.WriteLine("\n\n Vous êtes maigre !"); }

                    else if (imc < 16.5)
                    { Console.WriteLine("\n\n Dénutrition"); }


                    if (taille < 0.00 || taille > 3.00)
                    { Console.WriteLine("Saisie incorrect"); }


                    Console.WriteLine("Votre imc est de " + imc + "\n");

                }
            }
        }
    }
}