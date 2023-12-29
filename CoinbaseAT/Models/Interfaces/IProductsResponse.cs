// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IProductsResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Array of objects, each representing one product.
    /// </summary>
    IEnumerable<Product>? Products { get; set; }

    /// <summary>
    /// Number of products that were returned.
    /// </summary>
    int? Num_Products { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// Array of objects, each representing one product.
    /// </summary>
    IEnumerable<Product> Products { get; set; }

    /// <summary>
    /// Number of products that were returned.
    /// </summary>
    int Num_Products { get; set; }
#endif
}
