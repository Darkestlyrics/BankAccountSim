using System;
using BankSim.Enums;
using BankSim.Exceptions;
using BankSim.Helpers;


namespace BankSim {
    public class BankSimulator {
        /// <summary>
        /// Opens an Account with the specified details
        /// </summary>
        /// <param name="accNo">Account Number</param>
        /// <param name="accName">Account Name</param>
        /// <param name="accType">Account Type</param>
        /// <param name="accCurr">Account Currency</param>
        public void OpenAccount(string accNo, string accName, AccountType accType, Currencies accCurr)
        {

            if (string.IsNullOrEmpty(accNo))
            {
                throw new ArgumentNullException(nameof(accNo), "Account Cannot be null or empty");
            }
            if (string.IsNullOrEmpty(accName))
            {
                throw new ArgumentNullException(nameof(accName), "Account Cannot be null or empty");
            }
            if (AccountHelper.FindAccountByNumber(accNo) != null)
            {
                throw new AccountExistsException($"Account with Account Number {accNo} already exists");
            }

            AccountHelper.CreateAndOpenAccount(accNo, accName, accType, accCurr);
        }

        /// <summary>
        /// Closes the specified account
        /// </summary>
        /// <param name="accNo"></param>
        public void CloseAccount(string accNo = null)
        {

            if (string.IsNullOrEmpty(accNo))
            {
                throw new ArgumentNullException(nameof(accNo), "Account Cannot be null or empty");
            }

            AccountHelper.CloseAccount(accNo);
        }

        /// <summary>
        /// Transfer Funds from one account to Another
        /// </summary>
        /// <param name="accNo1">The Account to Transfer Funds From</param>
        /// <param name="accNo2">The Account to Transfer Funds To</param>
        /// <param name="amount">The Amount to Transfer</param>
        public void Transfer(string accNo1, string accNo2, double amount)
        {

            if (string.IsNullOrEmpty(accNo1))
            {
                throw new ArgumentNullException(nameof(accNo1), "Account Cannot be null or empty");
            }

            if (string.IsNullOrEmpty(accNo2))
            {
                throw new ArgumentNullException(nameof(accNo2), "Account Cannot be null or empty");
            }

            AccountHelper.TransferFunds(accNo1, accNo2, amount);
        }
    }
}
