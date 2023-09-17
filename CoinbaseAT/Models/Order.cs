// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IOrder"/>
/// </summary>
public class Order : IOrder
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? User_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public OrderConfiguration? Order_Configuration { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Side { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Client_Order_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Time_In_Force { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Created_Time { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Completion_Percentage { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Filled_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Average_Filled_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Fee { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Number_Of_Fills { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Filled_Value { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Pending_Cancel { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Size_In_Quote { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Total_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Size_Inclusive_Of_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Total_Value_After_Fees { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Trigger_Status { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Reject_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Settled { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Reject_Message { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Cancel_Message { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Placement_Source { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Outstanding_Hold_Amount { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Is_Liquidation { get; set; }
}
