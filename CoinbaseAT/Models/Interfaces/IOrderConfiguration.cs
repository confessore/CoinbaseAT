// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IOrderConfiguration
{
#if NET7_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    MarketMarketLoc? Market_Market_Loc { get; set; }

    /// <summary>
    ///
    /// </summary>
    LimitLimitGTC? Limit_Limit_GTC { get; set; }

    /// <summary>
    ///
    /// </summary>
    LimitLimitGTD? LimitLimitGTD { get; set; }

    /// <summary>
    ///
    /// </summary>
    StopLimitStopLimitGTC? Stop_Limit_Stop_Limit_GTC { get; set; }

    /// <summary>
    ///
    /// </summary>
    StopLimitStopLimitGTD? Stop_Limit_Stop_Limit_GTD { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    ///
    /// </summary>
    MarketMarketLoc Market_Market_Loc { get; set; }

    /// <summary>
    ///
    /// </summary>
    LimitLimitGTC Limit_Limit_GTC { get; set; }

    /// <summary>
    ///
    /// </summary>
    LimitLimitGTD LimitLimitGTD { get; set; }

    /// <summary>
    ///
    /// </summary>
    StopLimitStopLimitGTC Stop_Limit_Stop_Limit_GTC { get; set; }

    /// <summary>
    ///
    /// </summary>
    StopLimitStopLimitGTD Stop_Limit_Stop_Limit_GTD { get; set; }
#endif
}
