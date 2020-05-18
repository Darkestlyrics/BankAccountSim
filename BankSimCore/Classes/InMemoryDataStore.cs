#region Info
// BankAccount - BankSim - InMemoryDataStore.cs
// 
// Created by: Christopher Green
// 2019/04/10: 13:28
// 
// 
#endregion

using System.Collections.Generic;
using BankSim.Interfaces;

namespace BankSim.Classes
{
    /// <summary>
    /// Static implementation of Bank Accounts In Memory
    /// </summary>
    public static class InMemoryDataStore
    {
        internal static List<IAccount> Accounts = new List<IAccount>();
    }
    
}