// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IGoodsAndServicesTax
{
    /// <summary>
    ///
    /// </summary>
    string? Rate { get; set; }

    /// <summary>
    /// Possible values: [INCLUSIVE, EXCLUSIVE]
    /// </summary>
    string? Type { get; set; }
}
