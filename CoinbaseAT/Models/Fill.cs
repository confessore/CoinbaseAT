// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IFill"/>
/// </summary>
public class Fill : IFill
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Entry_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Trade_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Trade_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Trade_Type { get; set; }

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
    public string? Commission { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Sequence_Timestamp { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Liquidity_Indicator { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Size_In_Quote { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? User_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Side { get; set; }
}
