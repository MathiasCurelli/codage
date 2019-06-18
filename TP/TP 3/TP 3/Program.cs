using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
    class Program
    {
        static void Main(string[] args)
        {


            string studentName;
            string noteAgain = "oui";
           
            List<double> noteStudentList = new List<double>();
            //On initialise la variable qui permet de savoir si l'utilisateur rentre bien une note
            bool noteStudentIsNum;
            //On initialise la variable qui permet de stoker la note saisie
            double noteStudent;
            //On initialise la variable qui permet de stoker la somme de toute les notes
            double sumNote = 0;
            //On initialise la variable qui permet de stoker la moyenne
            double average;

            Console.WriteLine("Bonjour et bienvenue dans MonBulletinEnLigne, merci de saisir votre nom :");
            Console.WriteLine();

            studentName = Console.ReadLine();
            Console.WriteLine();

            while (noteAgain == "oui")
            {
                Console.WriteLine("Veuillez entrer une note obtenue ce trimestre élève" + "\n" + studentName + ":");

                noteStudentIsNum = double.TryParse(Console.ReadLine(), out noteStudent);

                while (noteStudentIsNum != true || noteStudent < 0 || noteStudent > 20)
                {
                    Console.WriteLine("Erreur de saisie");
                    noteStudentIsNum = double.TryParse(Console.ReadLine(), out noteStudent);
                }

                noteStudentList.Add(noteStudent);

                sumNote += noteStudent;

                Console.WriteLine("Souhaitez vous ajouter une nouvelle note? ( oui ou non)");
                noteAgain = Console.ReadLine().ToLower();


                while (noteAgain != "oui" && noteAgain != "non")
                {
                    Console.WriteLine("Saisie incorrect, veuillez saisir oui ou non");
                    noteAgain = Console.ReadLine().ToLower();

                }

            }

            average = sumNote / noteStudentList.Count();




            if (average > 18 && average < 20)
                    Console.WriteLine(average + "\n\n" + ", Excellent !");

                else if (average < 18 && average > 16)
                    Console.WriteLine(average + "\n" + "Très bien !");
                else if (average < 16 && average > 14)
                    Console.WriteLine(average + "\n" + "Bien");
                else if (average < 14 && average > 12)
                    Console.WriteLine(average + "\n" + "AB");
                else if (average < 12 && average > 10)
                    Console.WriteLine(average + "\n" + "Passable");
                else if (average < 10 && average > 6)
                    Console.WriteLine(average + "\n" + "Insuffisant");
                else if (average < 6 && average >= 0)
                    Console.WriteLine(average + "\n" + "Très insuffisant");

            Console.ReadLine();

  




        }
    }
}

