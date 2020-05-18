#region Info
// BankAccount - BankSim - CorporateAccount.cs
// 
// Created by: Christopher Green
// 2019/04/10: 11:22

#endregion

using BankSim.Enums;

namespace BankSim.Classes.Accounts
{
    internal class CorporateAccount : Account
    {
        public CorporateAccount(string accountNumber, string accountName, Currencies accountCurrency) : base(accountNumber, accountName, accountCurrency)
        {
        }
    }
}