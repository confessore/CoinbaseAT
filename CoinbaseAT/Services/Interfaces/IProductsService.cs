// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Threading.Tasks;
using CoinbaseAT.Models;

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IProductsService
{
    Task<ProductsResponse> ListProductsAsync(
        int limit = 0,
        int? offset = null,
        string? product_type = null,
        string[]? product_ids = null,
        string? contract_expiry_type = null
    );
}
