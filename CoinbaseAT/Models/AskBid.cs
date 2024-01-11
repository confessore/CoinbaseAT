// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAskBid"/>
/// </summary>
public class AskBid : IAskBid
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Size { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Size { get; set; }
#endif
}
