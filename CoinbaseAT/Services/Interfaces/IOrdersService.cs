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
}
