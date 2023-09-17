// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IOrderConfiguration"/>
/// </summary>
public class OrderConfiguration : IOrderConfiguration
{
    public MarketMarketLoc Market_Market_Loc { get; set; }

    public LimitLimitGTC Limit_Limit_GTC { get; set; }

    public LimitLimitGTD LimitLimitGTD { get; set; }

    public StopLimitStopLimitGTC Stop_Limit_Stop_Limit_GTC { get; set; }

    public StopLimitStopLimitGTD Stop_Limit_Stop_Limit_GTD { get; set; }
}
