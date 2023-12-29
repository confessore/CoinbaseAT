// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ITransactionSummary
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Total volume across assets, denoted in USD.
    /// </summary>
    double? Total_Volume { get; set; }

    /// <summary>
    /// Total fees across assets, denoted in USD.
    /// </summary>
    double? Total_Fees { get; set; }

    /// <summary>
    ///
    /// </summary>
    FeeTier? Fee_Tier { get; set; }

    /// <summary>
    /// Represents a decimal number with precision.
    /// </summary>
    MarginRate? Margin_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    GoodsAndServicesTax? Goods_And_Services_Tax { get; set; }

    /// <summary>
    /// Advanced Trade volume (non-inclusive of Pro) across assets, denoted in USD.
    /// </summary>
    double? Advanced_Trade_Only_Volume { get; set; }

    /// <summary>
    /// Advanced Trade fees (non-inclusive of Pro) across assets, denoted in USD.
    /// </summary>
    double? Advanced_Trade_Only_Fees { get; set; }

    /// <summary>
    /// Coinbase Pro volume across assets, denoted in USD.
    /// </summary>
    double? Coinbase_Pro_Volume { get; set; }

    /// <summary>
    /// Coinbase Pro fees across assets, denoted in USD.
    /// </summary>
    double? Coinbase_Pro_Fees { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// Total volume across assets, denoted in USD.
    /// </summary>
    double Total_Volume { get; set; }

    /// <summary>
    /// Total fees across assets, denoted in USD.
    /// </summary>
    double Total_Fees { get; set; }

    /// <summary>
    ///
    /// </summary>
    FeeTier Fee_Tier { get; set; }

    /// <summary>
    /// Represents a decimal number with precision.
    /// </summary>
    MarginRate Margin_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    GoodsAndServicesTax Goods_And_Services_Tax { get; set; }

    /// <summary>
    /// Advanced Trade volume (non-inclusive of Pro) across assets, denoted in USD.
    /// </summary>
    double Advanced_Trade_Only_Volume { get; set; }

    /// <summary>
    /// Advanced Trade fees (non-inclusive of Pro) across assets, denoted in USD.
    /// </summary>
    double Advanced_Trade_Only_Fees { get; set; }

    /// <summary>
    /// Coinbase Pro volume across assets, denoted in USD.
    /// </summary>
    double Coinbase_Pro_Volume { get; set; }

    /// <summary>
    /// Coinbase Pro fees across assets, denoted in USD.
    /// </summary>
    double Coinbase_Pro_Fees { get; set; }
#endif
}
