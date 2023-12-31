﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IAccountsResponse
{
    /// <summary>
    ///
    /// </summary>
    IEnumerable<Account>? Accounts { get; set; }

    /// <summary>
    ///
    /// </summary>
    bool? Has_Next { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Cursor { get; set; }

    /// <summary>
    ///
    /// </summary>
    int? Size { get; set; }
}
