// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using CoinbaseAT.Interfaces;
using Jose;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

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

    /// <summary>
    /// Generates a JSON Web Token (JWT) for authenticating requests with Cloud Trading API keys.
    /// The JWT can be used in the Authorization header of the HTTP request.
    /// </summary>
    /// <param name="key">The API key provided by Coinbase for Cloud API Trading.</param>
    /// <param name="secret">The API secret provided by Coinbase for Cloud API Trading.</param>
    /// <param name="service">The service identifier for the API (e.g., 'public_websocket_api' or 'retail_rest_api_proxy').</param>
    /// <param name="method">Optional. The HTTP method being used for the request (e.g., 'GET', 'POST'). Not required for WebSocket authentication.</param>
    /// <param name="path">Optional. The path of the API endpoint being accessed. Not required for WebSocket authentication.</param>
    /// <returns>A signed JWT in string format for use in the Authorization header.</returns>
    /// <exception cref="Exception">Throws an exception if there is an issue in generating the JWT.</exception>
    public string BuildJWT(string method = null, string path = null)
    {
        try
        {
            ECDsa privateKey = null;
            var modifiedSecret = APISecret.Replace("\\n", "\n");

            using (var reader = new StringReader(modifiedSecret))
            {
                var pemReader = new PemReader(reader);
                var keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
                var privateKeyParameters = (ECPrivateKeyParameters)keyPair.Private;
                var publicKeyParameters = (ECPublicKeyParameters)keyPair.Public;

                // Convert the private key 'D' value to a byte array
                var d = privateKeyParameters.D.ToByteArrayUnsigned();

                // Get the public key's elliptic curve point 'Q'
                var q = publicKeyParameters.Q;

                // Convert the X and Y coordinates of point 'Q' to byte arrays
                // These represent the public key components
                var x = q.AffineXCoord.GetEncoded();
                var y = q.AffineYCoord.GetEncoded();

                // Create a new ECDsa object with the specified ECParameters
                // The ECParameters include the curve details, private key 'D', and public key point 'Q'
                privateKey = ECDsa.Create(new ECParameters
                {
                    Curve = ECCurve.NamedCurves.nistP256, // Specify the elliptic curve used
                    D = d,                                // Set the private key component
                    Q = new ECPoint { X = x, Y = y }      // Set the public key components
                });
            }


            var request_host = "api.coinbase.com";
            var request_path = path != null && path.Contains("?") ? path.Substring(0, path.IndexOf('?')) : path;

            var payload = new Dictionary<string, object>
            {
                { "sub", APIKey },
                { "iss", "coinbase-cloud" },
                { "nbf", DateTimeOffset.UtcNow.ToUnixTimeSeconds() },
                { "exp", DateTimeOffset.UtcNow.AddSeconds(60).ToUnixTimeSeconds() },
                { "aud", new string[] { "retail_rest_api_proxy" } }
            };

            if (method != null && request_path != null)
            {
                payload.Add("uri", $"{method} {request_host}{request_path}");
            }

            var extraHeaders = new Dictionary<string, object>
            {
                { "kid", APIKey },
                { "nonce", GenerateNonce() },
                { "typ", "JWT" }
            };

            var token = JWT.Encode(payload, privateKey, JwsAlgorithm.ES256, extraHeaders: extraHeaders);
            privateKey?.Dispose();

            return token;
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Generates a unique nonce value.
    /// This method generates a 32-byte random value which is sufficiently large to ensure uniqueness and security.
    /// </summary>
    /// <returns>A nonce value as a 64-character lowercase hexadecimal string.</returns>
#pragma warning disable SYSLIB0023 // Disable the obsolete RNGCryptoServiceProvider warning
    private static string GenerateNonce()
    {
        var randomBytes = new byte[32];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(randomBytes);
        }
        return BitConverter.ToString(randomBytes).Replace("-", "").ToLower();
    }
#pragma warning restore SYSLIB0023 // Restore the warning
}
