// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAskBid"/>
/// </summary>
public class AskBid : IAskBid
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Size { get; set; }
}
