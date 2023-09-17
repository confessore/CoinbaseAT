// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IFutureProductDetails"/>
/// </summary>
public class FutureProductDetails : IFutureProductDetails
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Venue { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Code { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public DateTime? Contract_Expiry { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Root_Unit { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Group_Description { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Expiry_Timezone { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Group_Short_Description { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Risk_Managed_By { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Expiry_Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public PerpetualDetails? Perpetual_Details { get; set; }
}
