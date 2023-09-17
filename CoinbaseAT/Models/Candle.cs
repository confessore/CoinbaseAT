// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ICandle"/>
/// </summary>
public class Candle : ICandle
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Start { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Low { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? High { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Open { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Close { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Volume { get; set; }
}
