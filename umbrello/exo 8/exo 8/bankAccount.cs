using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_8
{
    class Bank_account
    {
        public string holder;
        public double balance;
        public string motto;

        public void Credit(double montant)
        {
            balance = balance + montant;
            return;
        }
        public void Debit(double montant)
        {
            balance = balance - montant;
            return;
        }

    }
}
