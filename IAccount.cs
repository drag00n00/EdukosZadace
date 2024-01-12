using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    public interface IAccount
    {
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    public class BankAccount : IAccount
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

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

    public class SavingsAccount : IAccount
    {
        private BankAccount bankAccount = new BankAccount();

        public decimal Balance => bankAccount.Balance;

        public void Deposit(decimal amount)
        {
            bankAccount.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            bankAccount.Withdraw(amount);
            // Additional logic for SavingsAccount withdrawal if needed
        }
    }
}
