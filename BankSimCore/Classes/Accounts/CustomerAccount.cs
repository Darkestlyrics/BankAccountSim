#region Info
// BankSim - BankSim - BankSim.cs
// 
// Created by: Christopher Green
// 2019/04/10: 09:09
// 
// 
#endregion

using BankSim.Enums;
using BankSim.Exceptions;

namespace BankSim.Classes.Accounts {
    internal class CustomerAccount : Account {

        /// <summary>
        /// Overdraft Details
        /// </summary>
        Overdraft Overdraft { get; }

        /// <summary>
        /// Account Restrictions
        /// </summary>
        AccountRestrictions Restrictions { get; }


        public CustomerAccount(string accountNumber, string accountName, Currencies accountCurrency, AccountRestrictions restrictions = null) : base(accountNumber, accountName, accountCurrency)
        {
            Overdraft = new Overdraft();
            if (restrictions == null)
                Restrictions = new AccountRestrictions();
        }
        /// <summary>
        /// Credits the Account for the amount (balance + amount)
        /// </summary>
        /// <param name="amount">the amount to credit</param>
        public override void Credit(double amount)
        {
            if (!Restrictions.AllowCredits)
            {
                throw new CreditsNotAllowedException("Account is flagged to Disallow Credits");
            }

            AccountBalance += amount;
        }
        /// <summary>
        /// Debits the Account for the amount (balance - amount)
        /// </summary>
        /// <param name="amount">the amount to debit</param>
        public override void Debit(double amount)
        {
            if (!Restrictions.AllowDebits)
            {
                throw new DebitsNotAllowedException("Account is flagged to Disallow Debits");
            }
            if (AccountBalance < amount)
            {
                if (Overdraft.OverDraftEnabled)
                {
                    if (amount < (AccountBalance + Overdraft.OverDraftAmount))
                    {
                        throw new InsufficientFundsException(
                            "Account has insufficient Funds and Overdraft amount will be exceeded");
                    }
                }
                throw new InsufficientFundsException(
                    "Account has insufficient Funds");
            }

            AccountBalance -= amount;
        }
    }
}
