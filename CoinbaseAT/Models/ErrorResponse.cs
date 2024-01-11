// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IErrorResponse"/>
/// </summary>
public class ErrorResponse : IErrorResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Error_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Preview_Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? New_Order_Failure_Reason { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Error { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Error_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Preview_Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string New_Order_Failure_Reason { get; set; }
#endif
}
