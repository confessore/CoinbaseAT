// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IProductsResponse"/>
/// </summary>
public class ProductsResponse : IProductsResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Product>? Products { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int? Num_Products { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Product> Products { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int Num_Products { get; set; }
#endif
}
