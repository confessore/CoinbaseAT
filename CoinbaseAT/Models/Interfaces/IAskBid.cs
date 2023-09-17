// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IAskBid
{
    /// <summary>
    ///
    /// </summary>
    string? Price { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Size { get; set; }
}
