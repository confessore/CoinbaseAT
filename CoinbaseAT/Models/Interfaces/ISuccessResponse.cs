// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface ISuccessResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// The ID of the order created
    /// </summary>
    string? Order_Id { get; set; }

    /// <summary>
    /// The product this order was created for e.g. 'BTC-USD'
    /// </summary>
    string? Product_Id { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_SIDE, BUY, SELL]
    /// </summary>
    string? Side { get; set; }

    /// <summary>
    /// Client set unique uuid for this order
    /// </summary>
    string? Client_Order_Id { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// The ID of the order created
    /// </summary>
    string Order_Id { get; set; }

    /// <summary>
    /// The product this order was created for e.g. 'BTC-USD'
    /// </summary>
    string Product_Id { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_ORDER_SIDE, BUY, SELL]
    /// </summary>
    string Side { get; set; }

    /// <summary>
    /// Client set unique uuid for this order
    /// </summary>
    string Client_Order_Id { get; set; }
#endif
}
