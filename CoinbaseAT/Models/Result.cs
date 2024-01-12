// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IResult"/>
/// </summary>
public class Result : IResult
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public SuccessResponse? Success_Response { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public ErrorResponse? Error_Response { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public OrderConfiguration? Order_Configuration { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Order_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public SuccessResponse Success_Response { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public ErrorResponse Error_Response { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public OrderConfiguration Order_Configuration { get; set; }
#endif
}
