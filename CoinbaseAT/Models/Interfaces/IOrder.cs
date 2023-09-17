// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IOrder
{
    /// <summary>
    /// The unique id for this order
    /// </summary>
    string? Order_Id { get; set; }

    /// <summary>
    /// The product this order was created for e.g. 'BTC-USD'
    /// </summary>
    string? Product_Id { get; set; }

    /// <summary>
    /// The id of the User owning this Order
    /// </summary>
    string? User_Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    OrderConfiguration? Order_Configuration { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_SIDE, BUY, SELL]
    /// </summary>
    string? Side { get; set; }

    /// <summary>
    /// Client specified ID of order.
    /// </summary>
    string? Client_Order_Id { get; set; }

    /// <summary>
    /// Possible values: [OPEN, FILLED, CANCELLED, EXPIRED, FAILED, UNKNOWN_ORDER_STATUS]
    /// </summary>
    string? Status { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_TIME_IN_FORCE, GOOD_UNTIL_DATE_TIME, GOOD_UNTIL_CANCELLED, IMMEDIATE_OR_CANCEL, FILL_OR_KILL]
    /// </summary>
    string? Time_In_Force { get; set; }

    /// <summary>
    /// Timestamp for when the order was created
    /// </summary>
    DateTime? Created_Time { get; set; }

    /// <summary>
    /// The percent of total order amount that has been filled
    /// </summary>
    string? Completion_Percentage { get; set; }

    /// <summary>
    /// The portion (in base currency) of total order amount that has been filled
    /// </summary>
    string? Filled_Size { get; set; }

    /// <summary>
    /// The average of all prices of fills for this order
    /// </summary>
    string? Average_Filled_Price { get; set; }

    /// <summary>
    /// Commission amount
    /// </summary>
    string? Fee { get; set; }

    /// <summary>
    /// Number of fills that have been posted for this order
    /// </summary>
    string? Number_Of_Fills { get; set; }

    /// <summary>
    /// The portion (in quote current) of total order amount that has been filled
    /// </summary>
    string? Filled_Value { get; set; }

    /// <summary>
    /// Whether a cancel request has been initiated for the order, and not yet completed
    /// </summary>
    bool? Pending_Cancel { get; set; }

    /// <summary>
    /// Whether the order was placed with quote currency
    /// </summary>
    bool? Size_In_Quote { get; set; }

    /// <summary>
    /// The total fees for the order
    /// </summary>
    string? Total_Fees { get; set; }

    /// <summary>
    /// Whether the order size includes fees
    /// </summary>
    bool? Size_Inclusive_Of_Fees { get; set; }

    /// <summary>
    /// derived field: filled_value + total_fees for buy orders and filled_value - total_fees for sell orders.
    /// </summary>
    string? Total_Value_After_Fees { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_TRIGGER_STATUS, INVALID_ORDER_TYPE, STOP_PENDING, STOP_TRIGGERED]
    /// </summary>
    string? Trigger_Status { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_TYPE, MARKET, LIMIT, STOP, STOP_LIMIT]
    /// </summary>
    string? Order_Type { get; set; }

    /// <summary>
    /// Possible values: [REJECT_REASON_UNSPECIFIED]
    /// </summary>
    string? Reject_Reason { get; set; }

    /// <summary>
    /// True if the order is fully filled, false otherwise.
    /// </summary>
    bool? Settled { get; set; }

    /// <summary>
    /// Possible values: [SPOT, FUTURE]
    /// </summary>
    string? Product_Type { get; set; }

    /// <summary>
    /// Message stating why the order was rejected.
    /// </summary>
    string? Reject_Message { get; set; }

    /// <summary>
    /// Message stating why the order was canceled.
    /// </summary>
    string? Cancel_Message { get; set; }

    /// <summary>
    /// Possible values: [RETAIL_SIMPLE, RETAIL_ADVANCED]
    /// </summary>
    string? Order_Placement_Source { get; set; }

    /// <summary>
    /// The remaining hold amount (holdAmount - holdAmountReleased). [value is 0 if holdReleased is true]
    /// </summary>
    string? Outstanding_Hold_Amount { get; set; }

    /// <summary>
    /// True if order is of liquidation type.
    /// </summary>
    bool? Is_Liquidation { get; set; }
}
