// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IFCMTradingSessionDetails"/>
/// </summary>
public class FCMTradingSessionDetails : IFCMTradingSessionDetails
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Is_Session_Open { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Open_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Close_Time { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Is_Session_Open { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime Open_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime Close_Time { get; set; }
#endif
}
