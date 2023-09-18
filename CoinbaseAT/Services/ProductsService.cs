// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

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
            stringBuilder.Append($"?offset={offset}");
        }

        if (product_type != null)
        {
            stringBuilder.Append($"?product_type={product_type}");
        }

        if (product_ids != null)
        {
            foreach (var product_id in product_ids)
            {
                stringBuilder.Append($"?product_ids={product_id}");
            }
        }

        if (contract_expiry_type != null)
        {
            stringBuilder.Append($"?contract_expiry_type={contract_expiry_type}");
        }

        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<ProductsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }

    public async Task<Product> GetProductAsync(string product_id)
    {
        return await SendServiceCall<Product>(
            HttpMethod.Get,
            $"/api/v3/brokerage/products/{product_id}"
        );
    }
}
