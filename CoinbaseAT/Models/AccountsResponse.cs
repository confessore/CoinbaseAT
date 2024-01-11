// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAccountsResponse"/>
/// </summary>
public class AccountsResponse : IAccountsResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Account>? Accounts { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Has_Next { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int? Size { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Account> Accounts { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Has_Next { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Cursor { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public int Size { get; set; }
#endif
}
