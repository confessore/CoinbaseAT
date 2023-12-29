// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ITransactionSummary"/>
/// </summary>
public class TransactionSummary : ITransactionSummary
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Total_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Total_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FeeTier? Fee_Tier { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public MarginRate? Margin_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public GoodsAndServicesTax? Goods_And_Services_Tax { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Advanced_Trade_Only_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Advanced_Trade_Only_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Coinbase_Pro_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double? Coinbase_Pro_Fees { get; set; }
#elif NETSTANDARD1_2_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Total_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Total_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FeeTier Fee_Tier { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public MarginRate Margin_Rate { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public GoodsAndServicesTax Goods_And_Services_Tax { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Advanced_Trade_Only_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Advanced_Trade_Only_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Coinbase_Pro_Volume { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public double Coinbase_Pro_Fees { get; set; }
#endif
}
