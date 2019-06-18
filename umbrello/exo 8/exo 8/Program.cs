using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_account AccountLaManu; // je déclare un nouvelle objet de type bank account
            AccountLaManu = new Bank_account // j'instancie le nouvel objet avec la class bank account
            {
                holder = "La Manu",
                balance = 2000,
                motto = "euros"
            };
            /* AccountLaManu.Credit(19);*/
            string holderUser;
            int balanceUser;
            double amountCredit;
            // je demande a l'utilisateur de renseigner le titulaire du compte
            Console.WriteLine("Veuillez renseigner le titulaire du compte ");
            // j'assigne ma variable à l'entrer de l'utilisateur
            holderUser = Console.ReadLine();
            // je demande de renseigner le solde du compte
            Console.WriteLine("Veuillez renseigner le solde du compte ");
            // je converti la saisie de l'utilisateur et je vérifie si c'est bien un nombre
            bool balanceUserisNum = int.TryParse(Console.ReadLine(), out balanceUser);
            while (!balanceUserisNum)
            {
                Console.WriteLine("saisie incorrecte"); // si ce n'est pas le cas, j'affiche saisie incorrecte
                balanceUserisNum = int.TryParse(Console.ReadLine(), out balanceUser);
            }
            // je demande de renseigner le montant à créditer
            Console.WriteLine("Veuillez renseigner le montant à créditer ");
            // je converti la saisie et je vérifie si c'est bien un nombre
            bool amountCreditisNum = double.TryParse(Console.ReadLine(), out amountCredit);
            // si ce n'est pas le cas ou si c'est inferieur a 0 
            while (!amountCreditisNum || amountCredit < 0)
            {
                Console.WriteLine("saisie incorrecte"); // j'affiche saisie incorrecte
                amountCreditisNum = double.TryParse(Console.ReadLine(), out amountCredit);
            }
            //  je récupère la méthode de l'objet AccountLaManu pour créditer le compte
            AccountLaManu.Credit(amountCredit);
            // j'affiche le titulaire, le sole de son compte en euros
            Console.WriteLine("le solde de " + AccountLaManu.holder + " est de " + AccountLaManu.balance + " " + AccountLaManu.motto);

        }
    }
}



