// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Services.Interfaces;

/// <summary>
///
/// </summary>
public interface IHttpClientService
{
    HttpClient HttpClient { get; set; }
    HttpRequestMessage CreateHttpRequestMessage(
        HttpMethod httpMethod,
        string requestPath,
        string contentBody = ""
    );
}
