// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoinbaseAT.Models;
using CoinbaseAT.Services.Abstractions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IAccountsService"/>
/// </summary>
public class AccountsService : CoinbaseATService, IAccountsService
{
    public AccountsService(IHttpClientService httpClientService)
        : base(httpClientService) { }

    public async Task<AccountsResponse> ListAccountsAsync(int limit = 49, string? cursor = null)
    {
        var requestPath = "/api/v3/brokerage/accounts";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        stringBuilder.Append($"?limit={limit}");
        if (cursor != null)
        {
            stringBuilder.Append($"&cursor={cursor}");
        }

        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<AccountsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    public async Task<Account> GetAccountAsync(string uuid)
    {
        return await SendServiceCall<Account>(HttpMethod.Get, $"/api/v3/brokerage/accounts/{uuid}");
    }
}
