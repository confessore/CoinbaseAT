﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IPricebooksResponse"/>
/// </summary>
public class PricebooksResponse : IPricebooksResponse
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Pricebook>? Pricebooks { get; set; }
}
