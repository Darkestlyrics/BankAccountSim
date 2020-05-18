#region Info
// BankSim - BankSim - Overdraft.cs
// 
// Created by: Christopher Green
// 2019/04/10: 08:57
// 
// 
#endregion

namespace BankSim.Classes
{
    internal class Overdraft
    {
        /// <summary>
        /// Flag to check if Overdraft is enabled
        /// </summary>
        public bool OverDraftEnabled { get; protected set; } = false;

        /// <summary>
        /// Amount an Account can go into Overdraft
        /// </summary>
        public double OverDraftAmount { get; protected set; } = 0;
    }
}