// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Text;
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

    public async Task<IEnumerable<Account>> ListAccountsAsync(
        int? limit = null,
        string? cursor = null
    )
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("/v3/brokerage/accounts");
        if (limit != null || cursor != null)
        {
            if (limit != null && cursor != null)
            {
                stringBuilder.Append($"?limit={limit}&cursor={cursor}");
            }
            else if (limit != null)
            {
                stringBuilder.Append($"?limit={limit}");
            }
            else if (cursor != null)
            {
                stringBuilder.Append($"?cursor={cursor}");
            }
        }

        var requestPath = stringBuilder.ToString();
        return await SendServiceCall<List<Account>>(HttpMethod.Get, requestPath);
    }

    public async Task<Account> GetAccountAsync(string uuid)
    {
        return await SendServiceCall<Account>(HttpMethod.Get, $"/v3/brokerage/accounts/{uuid}");
    }
}
