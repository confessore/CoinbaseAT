// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using CoinbaseAT.Extensions;
using CoinbaseAT.Interfaces;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services;

/// <summary>
/// <inheritdoc cref="IHttpClientService"/>
/// </summary>
public class HttpClientService : IHttpClientService
{
    private readonly ICoinbaseATConfiguration _coinbaseATConfiguration;
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpClientService(
        ICoinbaseATConfiguration coinbaseATConfiguration,
        IHttpClientFactory httpClientFactory
    )
    {
        _coinbaseATConfiguration = coinbaseATConfiguration;
        _httpClientFactory = httpClientFactory;
        HttpClient = CreateHttpClient();
    }

    public HttpClient HttpClient { get; set; }

    public HttpRequestMessage CreateHttpRequestMessage(
        HttpMethod httpMethod,
        string requestPath,
        string contentBody = ""
    )
    {
        var requestMessage = new HttpRequestMessage(
            httpMethod,
            new Uri(HttpClient.BaseAddress, requestPath)
        )
        {
            Content = new StringContent(contentBody, Encoding.UTF8, "application/json")
        };
        var timestamp = DateTime.UtcNow.ToTimestamp();
        var signature = _coinbaseATConfiguration.ComputeSignature(
            httpMethod,
            timestamp,
            requestPath,
            contentBody
        );
        //requestMessage.Headers.Add(
            //"CB-ACCESS-TIMESTAMP",
            //timestamp.ToString("F0", CultureInfo.InvariantCulture)
        //);
        //requestMessage.Headers.Add("CB-ACCESS-SIGN", signature);
        var jwt = _coinbaseATConfiguration.BuildJWT(httpMethod.Method, requestPath);
        requestMessage.Headers.Add("Authorization", $"Bearer {jwt}");
        return requestMessage;
    }

    public HttpRequestMessage CreateHttpRequestMessage(
        HttpMethod httpMethod,
        string requestPath,
        string fullRequestPath,
        string contentBody = ""
    )
    {
        var requestMessage = new HttpRequestMessage(
            httpMethod,
            new Uri(HttpClient.BaseAddress, fullRequestPath)
        )
        {
            Content = new StringContent(contentBody, Encoding.UTF8, "application/json")
        };
        var timestamp = DateTime.UtcNow.ToTimestamp();
        var signature = _coinbaseATConfiguration.ComputeSignature(
            httpMethod,
            timestamp,
            requestPath,
            contentBody
        );
        //requestMessage.Headers.Add(
        //"CB-ACCESS-TIMESTAMP",
        //timestamp.ToString("F0", CultureInfo.InvariantCulture)
        //);
        //requestMessage.Headers.Add("CB-ACCESS-SIGN", signature);
        var jwt = _coinbaseATConfiguration.BuildJWT(httpMethod.Method, requestPath);
        requestMessage.Headers.Add("Authorization", $"Bearer {jwt}");
        return requestMessage;
    }



    private HttpClient CreateHttpClient() =>
        _httpClientFactory.CreateClient(nameof(IHttpClientService));

}
