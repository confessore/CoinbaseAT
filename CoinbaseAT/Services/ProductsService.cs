﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoinbaseAT.Models;
using CoinbaseAT.Services.Abstractions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IProductsService"/>
/// </summary>
public class ProductsService : CoinbaseATService, IProductsService
{
    public ProductsService(IHttpClientService httpClientService)
        : base(httpClientService) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<PricebooksResponse> GetBestBidAskAsync(string[]? product_ids = null)
    {
        var requestPath = "/api/v3/brokerage/best_bid_ask";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);

        if (product_ids != null)
        {
            for (var i = 0; i < product_ids.Length; i++)
            {
                if (i != 0)
                {
                    stringBuilder.Append($"&product_ids={product_ids[i]}");
                    continue;
                }

                if (i == 0)
                {
                    stringBuilder.Append($"?product_ids={product_ids[i]}");
                }
            }
        }

        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<PricebooksResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<PricebookResponse> GetProductBookAsync(string product_id, int limit = 0)
    {
        var requestPath = "/api/v3/brokerage/product_book";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        stringBuilder.Append($"?limit={limit}");

        if (product_id != null)
        {
            stringBuilder.Append($"&product_id={product_id}");
        }

        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<PricebookResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<ProductsResponse> ListProductsAsync(
        int limit = 0,
        int? offset = null,
        string? product_type = null,
        string[]? product_ids = null,
        string? contract_expiry_type = null
    )
    {
        var requestPath = "/api/v3/brokerage/products";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        stringBuilder.Append($"?limit={limit}");
        if (offset != null)
        {
            stringBuilder.Append($"&offset={offset}");
        }

        if (product_type != null)
        {
            stringBuilder.Append($"&product_type={product_type}");
        }

        if (product_ids != null)
        {
            foreach (var product_id in product_ids)
            {
                stringBuilder.Append($"&product_ids={product_id}");
            }
        }

        if (contract_expiry_type != null)
        {
            stringBuilder.Append($"&contract_expiry_type={contract_expiry_type}");
        }

        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<ProductsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<Product> GetProductAsync(string product_id)
    {
        return await SendServiceCall<Product>(
            HttpMethod.Get,
            $"/api/v3/brokerage/products/{product_id}"
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<CandlesResponse> GetProductCandlesAsync(
        string product_id,
        string start,
        string end,
        string granularity
    )
    {
        var requestPath = $"/api/v3/brokerage/products/{product_id}/candles";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        stringBuilder.Append($"?start={start}");
        stringBuilder.Append($"&end={end}");
        stringBuilder.Append($"&granularity={granularity}");
        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<CandlesResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<TradesResponse> GetMarketTradesAsync(string product_id, int limit = 0)
    {
        var requestPath = $"/api/v3/brokerage/products/{product_id}/ticker";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        stringBuilder.Append($"?limit={limit}");
        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<TradesResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }
}
