// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IMarketMarketLoc"/>
/// </summary>
public class MarketMarketLoc : IMarketMarketLoc
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Size { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Size { get; set; }
#endif
}
