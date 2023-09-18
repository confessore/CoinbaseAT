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

    public async Task<ProductsResponse> ListProductsAsync()
    {
        var requestPath = "/api/v3/brokerage/products";
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(requestPath);
        var fullRequestPath = stringBuilder.ToString();
        return await SendServiceCall<ProductsResponse>(
            HttpMethod.Get,
            requestPath,
            fullRequestPath,
            string.Empty
        );
    }
}
