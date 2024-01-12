// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IResultsResponse"/>
/// </summary>
public class ResultsResponse : IResultsResponse
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Result>? Results { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Success { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Order_Id { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<Result> Results { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Success { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Failure_Reason { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Order_Id { get; set; }
#endif
}
