// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAccount"/>
/// </summary>
public class Account : IAccount
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Uuid { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? ProfileId { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public AccountBalance? Available_Balance { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Created_At { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Updated_At { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Deleted_At { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Ready { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public AccountHold? Hold { get; set; }
}
