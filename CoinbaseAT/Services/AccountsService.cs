// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models;
using CoinbaseAT.Services.Abstractions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IAccountsService"/>
/// </summary>
public class AccountsService : Service, IAccountsService
{
    public AccountsService(IHttpClientService httpClientService)
        : base(httpClientService) { }

    public async Task<IEnumerable<Account>> ListAccountsAsync(
        int? limit = null,
        string? cursor = null
    )
    {
        return await SendServiceCall<List<Account>>(HttpMethod.Get, "/accounts");
    }

    public async Task<Account> GetAccountAsync(string uuid)
    {
        return await SendServiceCall<Account>(HttpMethod.Get, $"/accounts/{uuid}");
    }
}
