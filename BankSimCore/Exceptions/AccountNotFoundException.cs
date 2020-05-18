#region Info
// BankAccount - BankSim - AccountNotFoundException.cs
// 
// Created by: Christopher Green
// 2019/04/10: 15:37
// 
// 
#endregion

using System;
using System.Runtime.Serialization;

namespace BankSim.Exceptions
{
    [Serializable]
    public class AccountNotFoundException : Exception
    {


        public AccountNotFoundException()
        {
        }

        public AccountNotFoundException(string message) : base(message)
        {
        }

        public AccountNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected AccountNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}