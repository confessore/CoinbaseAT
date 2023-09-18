// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Threading.Tasks;
using CoinbaseAT.Models;

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IOrdersService
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="order_id"></param>
    /// <param name="client_order_id"></param>
    /// <param name="user_native_currency"></param>
    /// <returns></returns>
    Task<OrderResponse> GetOrderAsync(
        string order_id,
        string? client_order_id = null,
        string? user_native_currency = null
    );

    /// <summary>
    ///
    /// </summary>
    /// <param name="order_id"></param>
    /// <param name="product_id"></param>
    /// <param name="start_sequence_timestamp"></param>
    /// <param name="end_sequence_timestamp"></param>
    /// <param name="limit"></param>
    /// <param name="cursor"></param>
    /// <returns></returns>
    Task<FillsResponse> ListFillsAsync(
        string? order_id = null,
        string? product_id = null,
        string? start_sequence_timestamp = null,
        string? end_sequence_timestamp = null,
        long? limit = null,
        string? cursor = null
    );

    /// <summary>
    ///
    /// </summary>
    /// <param name="product_id"></param>
    /// <param name="order_status"></param>
    /// <param name="limit"></param>
    /// <param name="start_date"></param>
    /// <param name="end_date"></param>
    /// <param name="user_native_currency"></param>
    /// <param name="order_type"></param>
    /// <param name="order_side"></param>
    /// <param name="cursor"></param>
    /// <param name="product_type"></param>
    /// <param name="order_placement_source"></param>
    /// <param name="contract_expiry_type"></param>
    /// <returns></returns>
    Task<FillsResponse> ListOrdersAsync(
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
    );
}
