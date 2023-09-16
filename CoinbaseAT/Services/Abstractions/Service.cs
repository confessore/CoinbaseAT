﻿// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Text.Json;
using CoinbaseAT.Exceptions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services.Abstractions;

public abstract class Service
{
    private protected readonly IHttpClientService _httpClientService;

    protected Service(IHttpClientService httpClientService)
    {
        _httpClientService = httpClientService;
    }

    private async Task<HttpResponseMessage> SendHttpRequestMessageAsync(
        HttpMethod httpMethod,
        string requestPath,
        string contentBody = ""
    )
    {
        var httpRequestMessage =
            contentBody == string.Empty
                ? _httpClientService.CreateHttpRequestMessage(httpMethod, requestPath)
                : _httpClientService.CreateHttpRequestMessage(httpMethod, requestPath, contentBody);

        var httpResponseMessage = await _httpClientService.HttpClient
            .SendAsync(httpRequestMessage)
            .ConfigureAwait(false);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return httpResponseMessage;
        }

        var result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

        string message;

        try
        {
            var obj = JsonSerializer.Deserialize<dynamic>(result);
            message = obj["Message"];
        }
        catch
        {
            message = contentBody;
        }

        var coinbaseATHttpRequestException = new CoinbaseATHttpRequestException(
            message,
            null,
            httpResponseMessage.StatusCode
        )
        {
            RequestMessage = httpRequestMessage,
            ResponseMessage = httpResponseMessage,
            //EndPoint = new EndPoint(httpMethod, uri, content)
        };

        throw coinbaseATHttpRequestException;
    }

    protected async Task<T> SendServiceCall<T>(
        HttpMethod httpMethod,
        string requestPath,
        string contentBody = ""
    )
    {
        var httpResponseMessage = await SendHttpRequestMessageAsync(
            httpMethod,
            requestPath,
            contentBody
        );
        var result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

        if (typeof(T) == typeof(string))
        {
            return (T)(object)result;
        }

        return JsonSerializer.Deserialize<T>(result);
    }
}
