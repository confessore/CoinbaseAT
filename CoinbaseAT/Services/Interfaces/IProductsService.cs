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
    /// <param name="product_ids"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    Task<PricebookResponse> GetProductBookAsync(string product_id, int limit = 0);

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

    /// <summary>
    ///
    /// </summary>
    /// <param name="product_id"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="granularity"></param>
    /// <returns></returns>
    Task<CandlesResponse> GetProductCandlesAsync(
        string product_id,
        string start,
        string end,
        string granularity
    );

    /// <summary>
    ///
    /// </summary>
    /// <param name="product_id"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    Task<TradesResponse> GetMarketTradesAsync(string product_id, int limit = 0);
}
