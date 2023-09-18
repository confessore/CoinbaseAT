// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Threading.Tasks;
using CoinbaseAT.Models;

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IAccountsService
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="limit"></param>
    /// <param name="cursor"></param>
    /// <returns></returns>
    Task<AccountsResponse> ListAccountsAsync(int limit = 49, string? cursor = null);

    /// <summary>
    ///
    /// </summary>
    /// <param name="uuid"></param>
    /// <returns></returns>
    Task<AccountResponse> GetAccountAsync(string uuid);
}
