// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interface;

/// <summary>
///
/// </summary>
public interface IProductResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    Product? Product { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    Product Product { get; set; }
#endif
}
