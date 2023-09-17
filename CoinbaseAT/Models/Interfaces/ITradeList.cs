// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ITradeList
{
    /// <summary>
    ///
    /// </summary>
    IEnumerable<Trade>? Trades { get; set; }

    /// <summary>
    /// The best bid for the `product_id`, in quote currency.
    /// </summary>
    string? Best_Bid { get; set; }

    /// <summary>
    /// The best ask for the `product_id`, in quote currency.
    /// </summary>
    string? Best_Ask { get; set; }
}
