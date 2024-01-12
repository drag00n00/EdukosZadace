using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    public class BankAccount
    {
        protected decimal Balance { get; set; }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }

    public class SavingsAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            // Bonus logic for SavingsAccount: penalize withdrawal
            base.Withdraw(amount);
            Balance -= 0.05m * amount; // Penalize by deducting 5% of the withdrawal amount
        }
    }
}
