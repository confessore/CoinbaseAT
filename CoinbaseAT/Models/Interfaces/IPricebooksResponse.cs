// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IPricebooksResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    IEnumerable<Pricebook>? Pricebooks { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    IEnumerable<Pricebook> Pricebooks { get; set; }
#endif
}
