// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interface;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IProductResponse"/>
/// </summary>
public class ProductResponse : IProductResponse
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Product? Product { get; set; }
}
