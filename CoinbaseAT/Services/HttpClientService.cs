// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

public class HttpClientService : IHttpClientService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpClientService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        HttpClient = CreateHttpClient();
    }

    public HttpClient HttpClient { get; set; }

    private HttpClient CreateHttpClient() =>
        _httpClientFactory.CreateClient(nameof(IHttpClientService));
}
