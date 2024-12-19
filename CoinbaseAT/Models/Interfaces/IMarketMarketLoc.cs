// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IMarketMarketIoc
{
    /// <summary>
    /// Amount of quote currency to spend on order. Required for BUY orders.
    /// </summary>
    string? Quote_Size { get; set; }

    /// <summary>
    /// Amount of base currency to spend on order. Required for SELL orders
    /// </summary>
    string? Base_Size { get; set; }
}
