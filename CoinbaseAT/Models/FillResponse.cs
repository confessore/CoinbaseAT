// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interface;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IFillResponse"/>
/// </summary>
public class FillResponse : IFillResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Fill? Fill { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Fill Fill { get; set; }
#endif
}
