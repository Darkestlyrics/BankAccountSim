#region Info
// BankSim - BankSim - DebitsNotAllowedException.cs
// 
// Created by: Christopher Green
// 2019/04/10: 09:23
// 
// 
#endregion

using System;
using System.Runtime.Serialization;

namespace BankSim.Exceptions
{
    [Serializable]
    public class DebitsNotAllowedException : Exception
    {

        public DebitsNotAllowedException()
        {
        }

        public DebitsNotAllowedException(string message) : base(message)
        {
        }

        public DebitsNotAllowedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DebitsNotAllowedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}