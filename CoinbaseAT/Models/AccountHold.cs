// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models;

/// <summary>
///
/// </summary>
public class AccountHold
{
    /// <summary>
    /// Amount of currency that this object represents.
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Denomination of the currency.
    /// </summary>
    public string? Currency { get; set; }
}
