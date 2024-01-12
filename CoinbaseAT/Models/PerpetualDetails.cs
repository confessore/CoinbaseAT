// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IPerpetualDetails"/>
/// </summary>
public class PerpetualDetails : IPerpetualDetails
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Open_Interest { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Funding_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Funding_Time { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Open_Interest { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Funding_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime Funding_Time { get; set; }
#endif
}
