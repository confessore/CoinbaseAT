// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interface;

/// <summary>
///
/// </summary>
public interface IOrderResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    Order? Order { get; set; }
#elif NETSTANDARD1_2_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    Order Order { get; set; }
#endif
}
