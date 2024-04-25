// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http;

namespace CoinbaseAT.Interfaces;

/// <summary>
///
/// </summary>
public interface ICoinbaseATConfiguration
{
    /// <summary>
    ///
    /// </summary>
    string APIKey { get; }

    /// <summary>
    ///
    /// </summary>
    string APISecret { get; }

    /// <summary>
    ///
    /// </summary>
    /// <param name="method"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestPath"></param>
    /// <param name="contentBody"></param>
    /// <returns></returns>
    string ComputeSignature(
        HttpMethod method,
        double timestamp,
        string requestPath,
        string contentBody = ""
    );

    string BuildJWT(string method, string path);
}
