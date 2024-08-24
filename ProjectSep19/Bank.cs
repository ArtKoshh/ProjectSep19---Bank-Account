using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSep19
{
    /*
  * Implement a class representing a bank account.
  * A bank account should have the following features:
  * - Deposit the specified amount of money
  * - Withdraw the specified amount of money.
  *   When the amount of money to widthrdaw is greater than the
  *   saldo the operation must fail.
  * - Transfer the specified amount to another account
  * - Query the Saldo of the account
  * - Query the Name of the owner
 */




    internal class Bank
    {
       public int Saldo { get; private set; }
        public string Name { get; private set; }

        public Bank(int initialSaldo, string owner)
        {
            Saldo = initialSaldo;
            Name = owner;
        }

        public void Withdraw(int w)
        {
            if (w > Saldo)
                throw new Exception("Not enough Credit");

            Saldo -= w;

        }

        public void Deposit(int d)
        {
             Saldo += d;
        }

        public void Transfer(int s, Bank konto)
        {
            Withdraw(s);
            konto.Deposit(s);
        }
        
        
    }

}
