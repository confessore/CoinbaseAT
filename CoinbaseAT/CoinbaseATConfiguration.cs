// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using CoinbaseAT.Interfaces;

namespace CoinbaseAT;

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

    public string APIKey { get; }

    public string APISecret { get; }

    public string ComputeSignature(
        HttpMethod httpMethod,
        string apiSecret,
        double timestamp,
        string requestPath,
        string body = ""
    )
    {
        var convertedString = Convert.FromBase64String(apiSecret);
        var prehash =
            timestamp.ToString("F0", CultureInfo.InvariantCulture)
            + httpMethod.Method
            + requestPath
            + body;
        return HashString(prehash, convertedString);
    }

    private static string HashString(string str, byte[] secret)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        using var hmaccsha = new HMACSHA256(secret);
        return Convert.ToBase64String(hmaccsha.ComputeHash(bytes));
    }
}
