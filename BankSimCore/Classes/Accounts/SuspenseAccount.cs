#region Info
// BankAccount - BankSim - SuspenseAccount.cs
// 
// Created by: Christopher Green
// 2019/04/10: 11:22

#endregion

using BankSim.Enums;


namespace BankSim.Classes.Accounts
{
    internal class SuspenseAccount: Account
    {

        public SuspenseAccount(string accountNumber, string accountName, Currencies accountCurrency) : base(accountNumber, accountName, accountCurrency)
        {
        }
    }
}