// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Threading.Tasks;
using CoinbaseAT.Models;

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IFeesService
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="start_date"></param>
    /// <param name="end_date"></param>
    /// <param name="user_native_currency"></param>
    /// <param name="product_type"></param>
    /// <param name="contract_expiry_type"></param>
    /// <returns></returns>
    Task<TransactionSummary> GetTransactionSummaryAsync(
        string? start_date = null,
        string? end_date = null,
        string? user_native_currency = null,
        string? product_type = null,
        string? contract_expiry_type = null
    );
}
