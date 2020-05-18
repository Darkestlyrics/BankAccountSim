#region Info
// BankSim - BankSim - InsufficientFundsException.cs
// 
// Created by: Christopher Green
// 2019/04/10: 09:33
// 
// 
#endregion

using System;
using System.Runtime.Serialization;

namespace BankSim.Exceptions
{
    [Serializable]
    public class InsufficientFundsException : Exception
    {


        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InsufficientFundsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}