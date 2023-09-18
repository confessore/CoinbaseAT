// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IResultList
{
    /// <summary>
    /// The result of initiated cancel requests
    /// </summary>
    public IEnumerable<Result>? Results { get; set; }

    /// <summary>
    /// Whether the cancel request was submitted successfully.
    /// </summary>
    public string? Success { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_CANCEL_FAILURE_REASON, INVALID_CANCEL_REQUEST, UNKNOWN_CANCEL_ORDER, COMMANDER_REJECTED_CANCEL_ORDER, DUPLICATE_CANCEL_REQUEST]
    /// </summary>
    public string? Failure_Reason { get; set; }

    /// <summary>
    /// The IDs of order cancel request was initiated for
    /// </summary>
    public string? Order_Id { get; set; }
}
