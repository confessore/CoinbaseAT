// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Models.Interface;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IAccountResponse"/>
/// </summary>
public class AccountResponse : IAccountResponse
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public Account? Account { get; set; }
}
