// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IOrderConfiguration"/>
/// </summary>
public class OrderConfiguration : IOrderConfiguration
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public MarketMarketLoc? Market_Market_Loc { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public LimitLimitGTC? Limit_Limit_GTC { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public LimitLimitGTD? LimitLimitGTD { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public StopLimitStopLimitGTC? Stop_Limit_Stop_Limit_GTC { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public StopLimitStopLimitGTD? Stop_Limit_Stop_Limit_GTD { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public MarketMarketLoc Market_Market_Loc { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public LimitLimitGTC Limit_Limit_GTC { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public LimitLimitGTD LimitLimitGTD { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public StopLimitStopLimitGTC Stop_Limit_Stop_Limit_GTC { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public StopLimitStopLimitGTD Stop_Limit_Stop_Limit_GTD { get; set; }
#endif
}
