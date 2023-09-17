// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IFeeTier
{
    /// <summary>
    /// Pricing tier for user, determined by notional (USD) volume.
    /// </summary>
    public string? Pricing_Tier { get; set; }

    /// <summary>
    /// Lower bound (inclusive) of pricing tier in notional volume.
    /// </summary>
    public string? USD_From { get; set; }

    /// <summary>
    /// Upper bound (exclusive) of pricing tier in notional volume.
    /// </summary>
    public string? USD_To { get; set; }

    /// <summary>
    /// Taker fee rate, applied if the order takes liquidity.
    /// </summary>
    public string? Taker_Fee_Rate { get; set; }

    /// <summary>
    /// Maker fee rate, applied if the order creates liquidity.
    /// </summary>
    public string? Maker_Fee_Rate { get; set; }
}
