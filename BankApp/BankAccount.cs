using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        #region PRIVATE FIELDS
        private string customerName;
        private double balance;
        #endregion

        #region PUBLIC PROPERTIES
        public string CustomerName { get => customerName; }
        public double Balance { get => balance; }
        #endregion

        #region CONSTRUCTORS
        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }
        #endregion

        #region METHODS
        public string GetBankAccountDetails()
        {
            return $"Ugyfel neve: {CustomerName}, egyenlege: {Balance}";
        }

        public void Debit(double amount)
        {
            if (amount > double.MaxValue)
            {
                throw new BankAccountCustomException("Tul nagy osszeget adott meg!");
            }

            if (amount < 0)
            {
                throw new BankAccountCustomException($"Az osszeg nem lehet negativ!");
            }

            if (amount > balance)
            {
                throw new BankAccountCustomException("Nincs eleg fedezet!");
            }

            this.balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount > double.MaxValue)
            {
                throw new BankAccountCustomException("Tul nagy osszeget adott meg!");
            }

            if (amount < 0)
            {
                throw new BankAccountCustomException("Az osszeg nem lehet negativ!");
            }

            this.balance += amount;
        }
        #endregion

    }
}
