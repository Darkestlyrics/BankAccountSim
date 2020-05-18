#region Info
// BankAccount - BankSim - Account.cs
// 
// Created by: Christopher Green
// 2019/04/10: 11:29
// 
// 
#endregion

using BankSim.Enums;
using BankSim.Interfaces;

namespace BankSim.Classes.Accounts {
    class Account : IAccount {
        public string AccountNumber { get; }
        public string AccountName { get; }
        public double AccountBalance { get; protected set; }
        public Currencies AccountCurrency { get; }

        /// <summary>
        /// Credit an Amount to the Account
        /// </summary>
        /// <param name="amount">The Amount to Credit</param>
        public virtual void Credit(double amount)
        {
            credit(amount);
        }

        /// <summary>
        /// Debit an Amount from the Account
        /// </summary>
        /// <param name="amount">The Amount to Debit</param>
        public virtual void Debit(double amount)
        {
            withdraw(amount);
        }

        /// <summary>
        /// Get the Current Account Balance
        /// </summary>
        /// <returns>The Account Balance</returns>
        public virtual double Balance()
        {
            return balance();
        }

        private void credit(double a)
        {
            AccountBalance += a;
        }

        private void withdraw(double a)
        {

            AccountBalance -= a;
        }

        private double balance()
        {
            return AccountBalance;
        }

        public Account(string accountNumber, string accountName, Currencies accountCurrency)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = 0;
            AccountCurrency = accountCurrency;
        }
    }
}