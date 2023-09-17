// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IFutureProductDetails
{
    /// <summary>
    ///
    /// </summary>
    string? Venue { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Contract_Code { get; set; }

    /// <summary>
    ///
    /// </summary>
    DateTime? Contract_Expiry { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Contract_Size { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Contract_Root_Unit { get; set; }

    /// <summary>
    /// Descriptive name for the product series, eg "Nano Bitcoin Futures".
    /// </summary>
    string? Group_Description { get; set; }

    /// <summary>
    ///
    /// </summary>
    string? Contract_Expiry_Timezone { get; set; }

    /// <summary>
    /// Short version of the group_description, eg "Nano BTC".
    /// </summary>
    string? Group_Short_Description { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_RISK_MANAGEMENT_TYPE, MANAGED_BY_FCM, MANAGED_BY_VENUE]
    /// </summary>
    string? Risk_Managed_By { get; set; }

    /// <summary>
    /// Possible values: [UNKNOWN_CONTRACT_EXPIRY_TYPE, EXPIRING]
    /// </summary>
    string? Contract_Expiry_Type { get; set; }

    /// <summary>
    ///
    /// </summary>
    PerpetualDetails? Perpetual_Details { get; set; }
}
