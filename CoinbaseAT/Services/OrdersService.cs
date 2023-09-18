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

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<FillsResponse> ListFillsAsync(
        string? order_id = null,
        string? product_id = null,
        string? start_sequence_timestamp = null,
        string? end_sequence_timestamp = null,
        long? limit = null,
        string? cursor = null
    )
    {
        var requestPath = $"/api/v3/brokerage/orders/historical/fill";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        if (order_id != null)
        {
            stringBuilder.Append($"?order_id={order_id}");
        }

        if (product_id != null)
        {
            stringBuilder.Append($"&product_id={product_id}");
        }

        if (start_sequence_timestamp != null)
        {
            stringBuilder.Append($"&start_sequence_timestamp={start_sequence_timestamp}");
        }

        if (end_sequence_timestamp != null)
        {
            stringBuilder.Append($"&end_sequence_timestamp={end_sequence_timestamp}");
        }

        if (limit != null)
        {
            stringBuilder.Append($"&limit={limit}");
        }

        if (cursor != null)
        {
            stringBuilder.Append($"&cursor={cursor}");
        }

        var fullRequestPath = stringBuilder.ToString();
        if (fullRequestPath.Contains('&') && !fullRequestPath.Contains('?'))
        {
            fullRequestPath = fullRequestPath.Remove(requestPath.Length, 1);
            fullRequestPath = fullRequestPath.Insert(requestPath.Length, "?");
        }

        return await SendServiceCall<FillsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<FillsResponse> ListOrdersAsync(
        string? product_id = null,
        string[]? order_status = null,
        int? limit = null,
        string? start_date = null,
        string? end_date = null,
        string? user_native_currency = null,
        string? order_type = null,
        string? order_side = null,
        string? cursor = null,
        string? product_type = null,
        string? order_placement_source = null,
        string? contract_expiry_type = null
    )
    {
        var requestPath = $"/api/v3/brokerage/orders/historical/batch";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        if (product_id != null)
        {
            stringBuilder.Append($"?product_id={product_id}");
        }

        if (order_status != null)
        {
            foreach (var status in order_status)
            {
                stringBuilder.Append($"&order_status={status}");
            }
        }

        if (limit != null)
        {
            stringBuilder.Append($"&limit={limit}");
        }

        if (start_date != null)
        {
            stringBuilder.Append($"&start_date={start_date}");
        }

        if (end_date != null)
        {
            stringBuilder.Append($"&end_date={end_date}");
        }

        if (user_native_currency != null)
        {
            stringBuilder.Append($"&user_native_currency={user_native_currency}");
        }

        if (order_type != null)
        {
            stringBuilder.Append($"&order_type={order_type}");
        }

        if (order_side != null)
        {
            stringBuilder.Append($"&order_side={order_side}");
        }

        if (cursor != null)
        {
            stringBuilder.Append($"&cursor={cursor}");
        }

        if (product_type != null)
        {
            stringBuilder.Append($"&product_type={product_type}");
        }

        if (order_placement_source != null)
        {
            stringBuilder.Append($"&order_placement_source={order_placement_source}");
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

        return await SendServiceCall<FillsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }
}
