// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IAccountHold
{
    /// <summary>
    /// Amount of currency that this object represents.
    /// </summary>
    string? Value { get; set; }

    /// <summary>
    /// Denomination of the currency.
    /// </summary>
    string? Currency { get; set; }
}
