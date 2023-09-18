// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoinbaseAT.Models;
using CoinbaseAT.Services.Abstractions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IFeesService"/>
/// </summary>
public class FeesService : CoinbaseATService, IFeesService
{
    public FeesService(IHttpClientService httpClientService)
        : base(httpClientService) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<TransactionSummary> GetTransactionSummaryAsync(
        string? start_date = null,
        string? end_date = null,
        string? user_native_currency = null,
        string? product_type = null,
        string? contract_expiry_type = null
    )
    {
        var requestPath = "/api/v3/brokerage/transaction_summary";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        if (start_date != null)
        {
            stringBuilder.Append($"?start_date={start_date}");
        }

        if (end_date != null)
        {
            stringBuilder.Append($"&end_date={end_date}");
        }

        if (user_native_currency != null)
        {
            stringBuilder.Append($"&user_native_currency={user_native_currency}");
        }

        if (product_type != null)
        {
            stringBuilder.Append($"&product_type={product_type}");
        }

        if (contract_expiry_type != null)
        {
            stringBuilder.Append($"&contract_expiry_type={contract_expiry_type}");
        }

        var fullRequestPath = stringBuilder.ToString();
        if (fullRequestPath.Contains('&') && !fullRequestPath.Contains('?'))
        {
            fullRequestPath = fullRequestPath.Remove(requestPath.Length, 1);
            fullRequestPath = fullRequestPath.Insert(requestPath.Length, "?");
        }

        return await SendServiceCall<TransactionSummary>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }
}
