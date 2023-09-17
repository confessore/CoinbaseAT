// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IFill
{
    /// <summary>
    /// Unique identifier for the fill.
    /// </summary>
    string? Entry_Id { get; set; }

    /// <summary>
    /// ID of the fill -- unique for all `FILL` trade_types but not unique for adjusted fills.
    /// </summary>
    string? Trade_Id { get; set; }

    /// <summary>
    /// ID of the order the fill belongs to.
    /// </summary>
    string? Order_Id { get; set; }

    /// <summary>
    /// Time at which this fill was completed.
    /// </summary>
    DateTime? Trade_Time { get; set; }

    /// <summary>
    /// String denoting what type of fill this is. Regular fills have the value `FILL`. Adjusted fills have possible values `REVERSAL`, `CORRECTION`, `SYNTHETIC`.
    /// </summary>
    string? Trade_Type { get; set; }

    /// <summary>
    /// Price the fill was posted at.
    /// </summary>
    string? Price { get; set; }

    /// <summary>
    /// Amount of order that was transacted at this fill.
    /// </summary>
    string? Size { get; set; }

    /// <summary>
    /// Fee amount for fill.
    /// </summary>
    string? Commission { get; set; }

    /// <summary>
    /// The product this order was created for.
    /// </summary>
    string? Product_Id { get; set; }

    /// <summary>
    /// Time at which this fill was posted.
    /// </summary>
    DateTime? Sequence_Timestamp { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_LIQUIDITY_INDICATOR, MAKER, TAKER]
    /// </summary>
    string? Liquidity_Indicator { get; set; }

    /// <summary>
    /// Whether the order was placed with quote currency.
    /// </summary>
    bool? Size_In_Quote { get; set; }

    /// <summary>
    /// User that placed the order the fill belongs to.
    /// </summary>
    string? User_Id { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_SIDE, BUY, SELL]
    /// </summary>
    string? Side { get; set; }
}
