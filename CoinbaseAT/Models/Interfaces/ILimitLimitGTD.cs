﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ILimitLimitGTD
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    string? Base_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    string? Limit_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    DateTime? End_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    bool? Post_Only { get; set; }
}
