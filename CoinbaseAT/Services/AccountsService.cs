// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

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

    public static async Task<IEnumerable<Account>> GetAllAccountsAsync()
    {
        return await SendServiceCall<List<Account>>(HttpMethod.Get, "/accounts");
    }

    public static async Task<Account> GetAccountByIdAsync(string id)
    {
        return await SendServiceCall<Account>(HttpMethod.Get, $"/accounts/{id}");
    }

    public static async Task<IList<IList<AccountHistory>>> GetAccountHistoryAsync(
        string id,
        int limit = 100,
        int numberOfPages = 0
    )
    {
        var httpResponseMessage = await SendHttpRequestMessagePagedAsync<AccountHistory>(
            HttpMethod.Get,
            $"/accounts/{id}/ledger?limit={limit}",
            numberOfPages: numberOfPages
        );

        return httpResponseMessage;
    }

    public static async Task<IList<IList<AccountHold>>> GetAccountHoldsAsync(
        string id,
        int limit = 100,
        int numberOfPages = 0
    )
    {
        var httpResponseMessage = await SendHttpRequestMessagePagedAsync<AccountHold>(
            HttpMethod.Get,
            $"/accounts/{id}/holds?limit={limit}",
            numberOfPages: numberOfPages
        );

        return httpResponseMessage;
    }
}
