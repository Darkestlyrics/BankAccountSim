#region Info
// BankSim - BankSim - IAccount.cs
// 
// Created by: Christopher Green
// 2019/04/10: 08:37

#endregion

using BankSim.Enums;

namespace BankSim.Interfaces {
    internal interface IAccount {

        /// <summary>
        /// The Account Number
        /// </summary>
        string AccountNumber { get; }

        /// <summary>
        /// The Name of the Account
        /// </summary>
        string AccountName { get;}

        /// <summary>
        /// The Balance of the Account
        /// </summary>
        double AccountBalance { get; }

        /// <summary>
        /// The Currency of the Account
        /// </summary>

        Currencies AccountCurrency { get; }

        void Debit(double amount);
        void Credit(double amount);
        double Balance();
    }
}