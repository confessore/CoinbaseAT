// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ITradesResponse"/>
/// </summary>
public class TradesResponse : ITradesResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Trade>? Trades { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Best_Bid { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Best_Ask { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Trade> Trades { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Best_Bid { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Best_Ask { get; set; }
#endif
}
