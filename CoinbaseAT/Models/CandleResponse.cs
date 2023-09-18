// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interface;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ICandleResponse"/>
/// </summary>
public class CandleResponse : ICandleResponse
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Candle? Candle { get; set; }
}
