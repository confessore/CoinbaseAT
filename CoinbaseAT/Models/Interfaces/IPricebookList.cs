// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IPricebookList
{
    /// <summary>
    ///
    /// </summary>
    IEnumerable<Pricebook>? Pricebooks { get; set; }
}
