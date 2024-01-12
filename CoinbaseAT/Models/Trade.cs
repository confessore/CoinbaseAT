// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ITrade"/>
/// </summary>
public class Trade : ITrade
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Trade_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Side { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Bid { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Ask { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Trade_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Side { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Bid { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Ask { get; set; }
#endif
}
