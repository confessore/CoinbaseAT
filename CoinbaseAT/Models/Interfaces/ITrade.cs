// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ITrade
{
    /// <summary>
    /// The ID of the trade that was placed.
    /// </summary>
    string? Trade_Id { get; set; }

    /// <summary>
    /// The trading pair.
    /// </summary>
    string? Product_Id { get; set; }

    /// <summary>
    /// The price of the trade, in quote currency.
    /// </summary>
    string? Price { get; set; }

    /// <summary>
    /// The size of the trade, in base currency.
    /// </summary>
    string? Size { get; set; }

    /// <summary>
    /// The time of the trade.
    /// </summary>
    DateTime? Time { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_SIDE, BUY, SELL]
    /// </summary>
    string? Side { get; set; }

    /// <summary>
    /// The best bid for the `product_id`, in quote currency.
    /// </summary>
    string? Bid { get; set; }

    /// <summary>
    /// The best ask for the `product_id`, in quote currency.
    /// </summary>
    string? Ask { get; set; }
}
