#region Info
// BankSim - BankSim - AccountRestrictions.cs
// 
// Created by: Christopher Green
// 2019/04/10: 08:39
// 
// 
#endregion

namespace BankSim.Classes {
    internal class AccountRestrictions
    {
        internal bool AllowCredits { get; } = true;
        internal bool AllowDebits { get;} = true;
        internal bool Open { get; } = true;

    }
}