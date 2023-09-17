// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
/// Represents a decimal number with precision.
/// </summary>
public interface IMarginRate
{
    /// <summary>
    /// String representation allows for unlimited precision.
    /// </summary>
    public string? Value { get; set; }
}
