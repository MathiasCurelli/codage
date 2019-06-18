using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6umbrello
{
    class Compte_Bancaire
    {
        //Je déclare mes attributs de la class Compte_Bancaire
        public int id;
        public string titulaire;
        public double solde;
        public string devise;

        public void Crediter(double montant) // Je déclare la méthode Crediter, le paramètre de la méthode est de type Double
            // Elle permet de créditer le solde de compte bancaire avec le montant contenu dans le paramètre
        {
            solde = solde + montant;
            return;
        }
        public void Debiter(double montant) // Pareil
        {
            solde = solde - montant;
            return;
        }
          
}

}
