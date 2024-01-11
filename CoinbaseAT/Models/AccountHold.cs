// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAccountHold"/>
/// </summary>
public class AccountHold : IAccountHold
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Currency { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Currency { get; set; }
#endif
}
