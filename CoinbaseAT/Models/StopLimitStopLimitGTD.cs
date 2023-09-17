// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IStopLimitStopLimitGTD"/>
/// </summary>
public class StopLimitStopLimitGTD : IStopLimitStopLimitGTD
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Limit_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Stop_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? End_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Stop_Direction { get; set; }
}
