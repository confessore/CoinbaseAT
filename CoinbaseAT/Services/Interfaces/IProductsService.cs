// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Threading.Tasks;
using CoinbaseAT.Models;

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IProductsService
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="product_ids"></param>
    /// <returns></returns>
    Task<PricebooksResponse> GetBestBidAskAsync(string[]? product_ids = null);

    /// <summary>
    ///
    /// </summary>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="product_type"></param>
    /// <param name="product_ids"></param>
    /// <param name="contract_expiry_type"></param>
    /// <returns></returns>
    Task<ProductsResponse> ListProductsAsync(
        int limit = 0,
        int? offset = null,
        string? product_type = null,
        string[]? product_ids = null,
        string? contract_expiry_type = null
    );

    /// <summary>
    ///
    /// </summary>
    /// <param name="product_id"></param>
    /// <returns></returns>
    Task<Product> GetProductAsync(string product_id);
}
