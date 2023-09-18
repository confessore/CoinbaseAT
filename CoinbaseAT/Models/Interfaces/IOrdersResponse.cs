// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IOrdersResponse
{
    /// <summary>
    /// A list of orders matching the query.
    /// </summary>
    IEnumerable<Order>? Orders { get; set; }

    /// <summary>
    /// The sequence of the db at which this state was read.
    /// </summary>
    long? Sequence { get; set; }

    /// <summary>
    /// Whether there are additional pages for this query.
    /// </summary>
    bool? Has_Next { get; set; }

    /// <summary>
    /// Cursor for paginating. Users can use this string to pass in the next call to this endpoint, and repeat this process to fetch all fills through pagination.
    /// </summary>
    string? Cursor { get; set; }
}
