﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ICandlesResponse"/>
/// </summary>
public class CandlesResponse : ICandlesResponse
{
    public IEnumerable<Candle>? Candles { get; set; }
}
