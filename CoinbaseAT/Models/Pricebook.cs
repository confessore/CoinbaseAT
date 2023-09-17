// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IPricebook"/>
/// </summary>
public class Pricebook : IPricebook
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<AskBid>? Bids { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<AskBid>? Asks { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Time { get; set; }
}
