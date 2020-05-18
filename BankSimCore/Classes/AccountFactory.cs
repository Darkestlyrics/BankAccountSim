#region Info
// BankSim - BankSim - AccountFactory.cs
// 
// Created by: Christopher Green
// 2019/04/10: 10:09

#endregion

using BankSim.Classes.Accounts;
using BankSim.Enums;

namespace BankSim.Classes
{
    internal static class AccountFactory
    {
        /// <summary>
        /// Creates an Account
        /// </summary>
        /// <param name="args">Account Args</param>
        /// <returns>Account</returns>
        internal static Account CreateAccount(AccountFactoryArgs args)
        {
            Account res = null;
            switch (args.AccountType)
            {
                case AccountType.CustomerAccount:
                    res = new CustomerAccount(args.AccountNumber,args.AccountName,args.AccountCurrency);
                    break;
                case AccountType.CorporateAccount:
                    res = new CorporateAccount(args.AccountNumber, args.AccountName, args.AccountCurrency);
                    break;
                case AccountType.SuspenseAccount:
                    res = new SuspenseAccount(args.AccountNumber, args.AccountName, args.AccountCurrency);
                    break;
            }
            return res;
        }
    }
}