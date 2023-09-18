// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoinbaseAT.Models;
using CoinbaseAT.Services.Abstractions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IOrdersService"/>
/// </summary>
public class OrdersService : CoinbaseATService, IOrdersService
{
    public OrdersService(IHttpClientService httpClientService)
        : base(httpClientService) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<OrderResponse> GetOrderAsync(
        string order_id,
        string? client_order_id = null,
        string? user_native_currency = null
    )
    {
        var requestPath = $"/api/v3/brokerage/orders/historical/{order_id}";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        if (client_order_id != null)
        {
            stringBuilder.Append($"?client_order_id={client_order_id}");
        }

        if (user_native_currency != null)
        {
            stringBuilder.Append($"&user_native_currency={user_native_currency}");
        }

        var fullRequestPath = stringBuilder.ToString();
        if (fullRequestPath.Contains('&') && !fullRequestPath.Contains('?'))
        {
            fullRequestPath = fullRequestPath.Remove(requestPath.Length, 1);
            fullRequestPath = fullRequestPath.Insert(requestPath.Length, "?");
        }

        return await SendServiceCall<OrderResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }
}
