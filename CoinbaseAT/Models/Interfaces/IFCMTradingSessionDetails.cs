// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IFCMTradingSessionDetails
{
    /// <summary>
    ///
    /// </summary>
    bool? Is_Session_Open { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime? Open_Time { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime? Close_Time { get; set; }
}
