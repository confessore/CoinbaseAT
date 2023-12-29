// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IStopLimitStopLimitGTD
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Amount of base currency to spend on order
    /// </summary>
    string? Base_Size { get; set; }

    /// <summary>
    /// Ceiling price for which the order should get filled
    /// </summary>
    string? Limit_Price { get; set; }

    /// <summary>
    /// Price at which the order should trigger - if stop direction is Up, then the order will trigger when the last trade price goes above this, otherwise order will trigger when last trade price goes below this price.
    /// </summary>
    string? Stop_Price { get; set; }

    /// <summary>
    /// Time at which the order should be cancelled if it's not filled.
    /// </summary>
    DateTime? End_Time { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_STOP_DIRECTION, STOP_DIRECTION_STOP_UP, STOP_DIRECTION_STOP_DOWN]
    /// </summary>
    string? Stop_Direction { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// Amount of base currency to spend on order
    /// </summary>
    string Base_Size { get; set; }

    /// <summary>
    /// Ceiling price for which the order should get filled
    /// </summary>
    string Limit_Price { get; set; }

    /// <summary>
    /// Price at which the order should trigger - if stop direction is Up, then the order will trigger when the last trade price goes above this, otherwise order will trigger when last trade price goes below this price.
    /// </summary>
    string Stop_Price { get; set; }

    /// <summary>
    /// Time at which the order should be cancelled if it's not filled.
    /// </summary>
    DateTime End_Time { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_STOP_DIRECTION, STOP_DIRECTION_STOP_UP, STOP_DIRECTION_STOP_DOWN]
    /// </summary>
    string Stop_Direction { get; set; }
#endif
}
