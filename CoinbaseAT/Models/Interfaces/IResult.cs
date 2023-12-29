// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IResult
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Whether the order was created.
    /// </summary>
    bool? Success { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_FAILURE_REASON, UNSUPPORTED_ORDER_CONFIGURATION, INVALID_SIDE, INVALID_PRODUCT_ID, INVALID_SIZE_PRECISION, INVALID_PRICE_PRECISION, INSUFFICIENT_FUND, INVALID_LEDGER_BALANCE, ORDER_ENTRY_DISABLED, INELIGIBLE_PAIR, INVALID_LIMIT_PRICE_POST_ONLY, INVALID_LIMIT_PRICE, INVALID_NO_LIQUIDITY, INVALID_REQUEST, COMMANDER_REJECTED_NEW_ORDER, INSUFFICIENT_FUNDS]
    /// </summary>
    string? Failure_Reason { get; set; }

    /// <summary>
    /// The ID of the order created
    /// </summary>
    string? Order_Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    SuccessResponse? Success_Response { get; set; }

    /// <summary>
    ///
    /// </summary>
    ErrorResponse? Error_Response { get; set; }

    /// <summary>
    ///
    /// </summary>
    OrderConfiguration? Order_Configuration { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// Whether the order was created.
    /// </summary>
    bool Success { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_FAILURE_REASON, UNSUPPORTED_ORDER_CONFIGURATION, INVALID_SIDE, INVALID_PRODUCT_ID, INVALID_SIZE_PRECISION, INVALID_PRICE_PRECISION, INSUFFICIENT_FUND, INVALID_LEDGER_BALANCE, ORDER_ENTRY_DISABLED, INELIGIBLE_PAIR, INVALID_LIMIT_PRICE_POST_ONLY, INVALID_LIMIT_PRICE, INVALID_NO_LIQUIDITY, INVALID_REQUEST, COMMANDER_REJECTED_NEW_ORDER, INSUFFICIENT_FUNDS]
    /// </summary>
    string Failure_Reason { get; set; }

    /// <summary>
    /// The ID of the order created
    /// </summary>
    string Order_Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    SuccessResponse Success_Response { get; set; }

    /// <summary>
    ///
    /// </summary>
    ErrorResponse Error_Response { get; set; }

    /// <summary>
    ///
    /// </summary>
    OrderConfiguration Order_Configuration { get; set; }
#endif
}
