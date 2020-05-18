#region Info
// BankAccount - BankSim - AccountFactoryArgs.cs
// 
// Created by: Christopher Green
// 2019/04/10: 11:14
// 
// 
#endregion

using BankSim.Enums;

namespace BankSim.Classes
{
    internal class AccountFactoryArgs
    {
        public AccountType AccountType { get; set; }
        public string AccountName { get; set; }
        public Currencies AccountCurrency { get; set; }
        public string AccountNumber { get; set; }   

    }
}