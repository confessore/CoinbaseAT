// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using System.Globalization;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using CoinbaseAT.Interfaces;

namespace CoinbaseAT;

/// <summary>
/// <inheritdoc cref="ICoinbaseATConfiguration"/>
/// </summary>
public class CoinbaseATConfiguration : ICoinbaseATConfiguration
{
    public CoinbaseATConfiguration(string apiKey, string apiSecret)
    {
        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret))
        {
            throw new ArgumentException(
                $"{nameof(CoinbaseATConfiguration)} requires parameters {nameof(apiKey)}, and {nameof(apiSecret)} to be populated."
            );
        }

        APIKey = apiKey;
        APISecret = apiSecret;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string APIKey { get; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string APISecret { get; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string ComputeSignature(
        HttpMethod httpMethod,
        double timestamp,
        string requestPath,
        string contentBody = ""
    )
    {
        var bytes = Encoding.UTF8.GetBytes(APISecret);
        var prehash =
            timestamp.ToString("F0", CultureInfo.InvariantCulture)
            + httpMethod.Method
            + requestPath
            + contentBody;
        return HashString(prehash, bytes);
    }

    private static string HashString(string str, byte[] secret)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        using var hmaccsha = new HMACSHA256(secret);
        return Convert.ToHexString(hmaccsha.ComputeHash(bytes)).ToLower();
    }
}
