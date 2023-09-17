// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IPricebookList"/>
/// </summary>
public class PricebookList : IPricebookList
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Pricebook>? Pricebooks { get; set; }
}
