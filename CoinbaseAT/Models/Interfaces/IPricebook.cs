// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IPricebook
{
    /// <summary>
    ///
    /// </summary>
    string? Product_Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    IEnumerable<AskBid>? Bids { get; set; }

    /// <summary>
    ///
    /// </summary>
    IEnumerable<AskBid>? Asks { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime? Time { get; set; }
}
