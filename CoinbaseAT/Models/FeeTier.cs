// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IFeeTier"/>
/// </summary>
public class FeeTier : IFeeTier
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Pricing_Tier { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? USD_From { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? USD_To { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Taker_Fee_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Maker_Fee_Rate { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Pricing_Tier { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string USD_From { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string USD_To { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Taker_Fee_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Maker_Fee_Rate { get; set; }
#endif
}
