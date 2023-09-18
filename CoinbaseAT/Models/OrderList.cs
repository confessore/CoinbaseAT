// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IOrderList"/>
/// </summary>
public class OrderList : IOrderList
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Order>? Orders { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public long? Sequence { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Has_Next { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Cursor { get; set; }
}
