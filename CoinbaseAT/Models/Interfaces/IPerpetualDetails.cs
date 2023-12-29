// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IPerpetualDetails
{
#if NET7_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    string? Open_Interest { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Funding_Rate { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime? Funding_Time { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    string Open_Interest { get; set; }

    /// <summary>
    ///
    /// </summary>
    string Funding_Rate { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime Funding_Time { get; set; }
#endif
}
