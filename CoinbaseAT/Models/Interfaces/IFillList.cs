// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IFillList
{
    /// <summary>
    /// All fills matching the filters.
    /// </summary>
    IEnumerable<Fill>? Fills { get; set; }

    /// <summary>
    /// Cursor for paginating. Users can use this string to pass in the next call to this endpoint, and repeat this process to fetch all fills through pagination.
    /// </summary>
    string? Cursor { get; set; }
}
