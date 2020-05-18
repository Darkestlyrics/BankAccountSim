#region Info
// BankAccount - BankSim - AccountHelper.cs
// 
// Created by: Christopher Green
// 2019/04/10: 13:27
// 
// 
#endregion

using System.Linq;
using BankSim.Classes;
using BankSim.Classes.Accounts;
using BankSim.Enums;
using BankSim.Exceptions;
using BankSim.Interfaces;

namespace BankSim.Helpers {
    internal static class AccountHelper {
        /*
         * Violates the Single Responsibility Principle
         * Does a number of things outside of a single scope
         */

        internal static IAccount FindAccountByNumber(string search)
        {
            return InMemoryDataStore.Accounts.FirstOrDefault(o => o.AccountNumber.ToUpper() == search);
        }
        //v1
        internal static void CreateAndOpenAccount(string accNo, string accName, AccountType type, Currencies accCurr)
        {
            AccountFactoryArgs args = new AccountFactoryArgs()
            {
                AccountCurrency = accCurr,
                AccountNumber = accNo,
                AccountName = accName,
                AccountType = type
            };
            Account newAccount = AccountFactory.CreateAccount(args);        
            InMemoryDataStore.Accounts.Add(newAccount);                         
        }
        //v1
        internal static void TransferFunds(string creditAccount, string debitAccount, double amount)
        {
            IAccount crAccount = FindAccountByNumber(creditAccount);
            IAccount drAccount = FindAccountByNumber(debitAccount);
            if(crAccount == null)
                throw new AccountNotFoundException("Account does not exist");
            if (drAccount == null)
                throw new AccountNotFoundException("Account does not exist");
            drAccount.Debit(amount);
            crAccount.Credit(amount);
        }
        //v2
        internal static  void TransferFunds(ref IAccount creditAccount, ref IAccount debitAccount, double amount)
        {
            debitAccount.Debit(amount);
            creditAccount.Credit(amount);
        }
        //v1
        internal static void CloseAccount(string accNo)
        {
            IAccount account = FindAccountByNumber(accNo);
            if(account ==null)
                throw new AccountNotFoundException("Account does not exist");
            InMemoryDataStore.Accounts.Remove(account);
        }

        internal static void CloseAccount(IAccount account)
        {
            InMemoryDataStore.Accounts.Remove(account);
        }
    }


}