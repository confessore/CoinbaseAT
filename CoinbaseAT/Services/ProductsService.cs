// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

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
}
