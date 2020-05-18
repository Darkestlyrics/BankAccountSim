#region Info
// BankAccount - BankSim - AccountExistsException.cs
// 
// Created by: Christopher Green
// 2019/04/10: 14:38
// 
// 
#endregion

using System;
using System.Runtime.Serialization;

namespace BankSim.Exceptions
{
    [Serializable]
    public class AccountExistsException : Exception
    {
 
        public AccountExistsException()
        {
        }

        public AccountExistsException(string message) : base(message)
        {
        }

        public AccountExistsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected AccountExistsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}