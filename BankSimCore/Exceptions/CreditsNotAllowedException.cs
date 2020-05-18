#region Info
// BankSim - BankSim - CreditsNotAllowedException.cs
// 
// Created by: Christopher Green
// 2019/04/10: 09:21
// 
// 
#endregion

using System;
using System.Runtime.Serialization;

namespace BankSim.Exceptions {
    [Serializable]
    public class CreditsNotAllowedException : Exception {


        public CreditsNotAllowedException()
        {
        }

        public CreditsNotAllowedException(string message) : base(message)
        {
            if (string.IsNullOrEmpty(message))
            {
            }
        }

        public CreditsNotAllowedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CreditsNotAllowedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}