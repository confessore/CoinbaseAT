// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interface;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IPricebookResponse"/>
/// </summary>
public class PricebookResponse : IPricebookResponse
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Pricebook? Pricebook { get; set; }
}
