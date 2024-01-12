// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Models.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface IAccount
    {
#if NET7_0_OR_GREATER
        /// <summary>
        /// Unique identifier for account.
        /// </summary>
        string? Uuid { get; set; }

        /// <summary>
        /// Name for the account.
        /// </summary>
        string? ProfileId { get; set; }

        /// <summary>
        /// Currency symbol for the account.
        /// </summary>
        string? Currency { get; set; }

        /// <summary>
        ///
        /// </summary>
        AccountBalance? Available_Balance { get; set; }

        /// <summary>
        /// Whether or not this account is the user's primary account.
        /// </summary>
        bool? Default { get; set; }

        /// <summary>
        /// Whether or not this account is active and okay to use.
        /// </summary>
        bool? Active { get; set; }

        /// <summary>
        /// Time at which this account was created.
        /// </summary>
        DateTime? Created_At { get; set; }

        /// <summary>
        /// Time at which this account was updated.
        /// </summary>
        DateTime? Updated_At { get; set; }

        /// <summary>
        /// Time at which this account was deleted.
        /// </summary>
        DateTime? Deleted_At { get; set; }

        /// <summary>
        /// Possible values: [ACCOUNT_TYPE_UNSPECIFIED, ACCOUNT_TYPE_CRYPTO, ACCOUNT_TYPE_FIAT, ACCOUNT_TYPE_VAULT]
        /// </summary>
        string? Type { get; set; }

        /// <summary>
        /// Whether or not this account is ready to trade.
        /// </summary>
        bool? Ready { get; set; }

        /// <summary>
        ///
        /// </summary>
        AccountHold? Hold { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
        /// <summary>
        /// Unique identifier for account.
        /// </summary>
        string Uuid { get; set; }

        /// <summary>
        /// Name for the account.
        /// </summary>
        string ProfileId { get; set; }

        /// <summary>
        /// Currency symbol for the account.
        /// </summary>
        string Currency { get; set; }

        /// <summary>
        ///
        /// </summary>
        AccountBalance Available_Balance { get; set; }

        /// <summary>
        /// Whether or not this account is the user's primary account.
        /// </summary>
        bool Default { get; set; }

        /// <summary>
        /// Whether or not this account is active and okay to use.
        /// </summary>
        bool Active { get; set; }

        /// <summary>
        /// Time at which this account was created.
        /// </summary>
        DateTime Created_At { get; set; }

        /// <summary>
        /// Time at which this account was updated.
        /// </summary>
        DateTime Updated_At { get; set; }

        /// <summary>
        /// Time at which this account was deleted.
        /// </summary>
        DateTime Deleted_At { get; set; }

        /// <summary>
        /// Possible values: [ACCOUNT_TYPE_UNSPECIFIED, ACCOUNT_TYPE_CRYPTO, ACCOUNT_TYPE_FIAT, ACCOUNT_TYPE_VAULT]
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Whether or not this account is ready to trade.
        /// </summary>
        bool Ready { get; set; }

        /// <summary>
        ///
        /// </summary>
        AccountHold Hold { get; set; }
#endif
    }
}
