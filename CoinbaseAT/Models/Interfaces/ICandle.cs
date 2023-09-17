// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ICandle
{
    /// <summary>
    /// Timestamp for bucket start time, in UNIX time.
    /// </summary>
    string? Start { get; set; }

    /// <summary>
    /// Lowest price during the bucket interval.
    /// </summary>
    string? Low { get; set; }

    /// <summary>
    /// Highest price during the bucket interval.
    /// </summary>
    string? High { get; set; }

    /// <summary>
    /// Opening price (first trade) in the bucket interval.
    /// </summary>
    string? Open { get; set; }

    /// <summary>
    /// Closing price (last trade) in the bucket interval.
    /// </summary>
    string? Close { get; set; }

    /// <summary>
    /// Volume of trading activity during the bucket interval.
    /// </summary>
    string? Volume { get; set; }
}
