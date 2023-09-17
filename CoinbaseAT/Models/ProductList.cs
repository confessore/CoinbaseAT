// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IProductList"/>
/// </summary>
public class ProductList : IProductList
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Product>? Products { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int? Num_Products { get; set; }
}
