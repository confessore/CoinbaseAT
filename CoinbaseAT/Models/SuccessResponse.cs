// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="ISuccessResponse"/>
/// </summary>
public class SuccessResponse : ISuccessResponse
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
    public string? Side { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Client_Order_Id { get; set; }
}
