// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Interfaces;

/// <summary>
///
/// </summary>
public interface ICoinbaseATClient
{
    /// <summary>
    ///
    /// </summary>
    IAccountsService AccountsService { get; }

    /// <summary>
    ///
    /// </summary>
    IFeesService FeesService { get; }

    /// <summary>
    ///
    /// </summary>
    IOrdersService OrdersService { get; }

    /// <summary>
    ///
    /// </summary>
    IProductsService ProductsService { get; }
}
