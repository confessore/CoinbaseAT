// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ILimitLimitGTC
{
    /// <summary>
    /// Amount of base currency to spend on order
    /// </summary>
    string? Base_Size { get; set; }

    /// <summary>
    /// Ceiling price for which the order should get filled
    /// </summary>
    string? Limit_Price { get; set; }

    /// <summary>
    /// Post only limit order
    /// </summary>
    bool? Post_Only { get; set; }
}
