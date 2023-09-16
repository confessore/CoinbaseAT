// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using CoinbaseAT.Interfaces;

namespace CoinbaseAT;

public class CoinbaseATConfiguration : ICoinbaseATConfiguration
{
    public CoinbaseATConfiguration(
            string apiKey,
            string unsignedSignature,
            string passphrase)
    {
        if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(unsignedSignature) ||
            string.IsNullOrEmpty(passphrase))
        {
            throw new ArgumentException(
                $"{nameof(CoinbaseATConfiguration)} requires parameters {nameof(apiKey)}, {nameof(unsignedSignature)} and {nameof(passphrase)} to be populated.");
        }

        ApiKey = apiKey;
        UnsignedSignature = unsignedSignature;
        Passphrase = passphrase;
    }

    public string ApiKey { get; }

    public string UnsignedSignature { get; }

    public string Passphrase { get; }

    public static string ComputeSignature(
        HttpMethod httpMethod,
        string secret,
        double timestamp,
        string requestUri,
        string contentBody = "")
    {
        var convertedString = Convert.FromBase64String(secret);
        var prehash = timestamp.ToString("F0", CultureInfo.InvariantCulture) + httpMethod.ToString().ToUpper() + requestUri + contentBody;
        return HashString(prehash, convertedString);
    }

    private static string HashString(string str, byte[] secret)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        using var hmaccsha = new HMACSHA256(secret);
        return Convert.ToBase64String(hmaccsha.ComputeHash(bytes));
    }
}
