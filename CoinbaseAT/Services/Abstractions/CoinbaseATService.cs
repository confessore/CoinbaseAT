// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CoinbaseAT.Exceptions;
using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services.Abstractions;

public abstract class CoinbaseATService
{
    private protected readonly IHttpClientService _httpClientService;

    protected CoinbaseATService(IHttpClientService httpClientService)
    {
        _httpClientService = httpClientService;
    }

    private async Task<HttpResponseMessage> SendHttpRequestMessageAsync(
        HttpMethod httpMethod,
        string requestPath,
        string contentBody = ""
    )
    {
        var httpRequestMessage = _httpClientService.CreateHttpRequestMessage(
            httpMethod,
            requestPath,
            contentBody
        );

        var httpResponseMessage = await _httpClientService.HttpClient
            .SendAsync(httpRequestMessage)
            .ConfigureAwait(false);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return httpResponseMessage;
        }

        var result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

        string message;
        Exception exception = new();

        try
        {
            message = result;
        }
        catch (Exception e)
        {
            exception = e;
            message = contentBody;
        }

        var coinbaseATHttpRequestException = new CoinbaseATHttpRequestException(
            message,
            exception,
            httpResponseMessage.StatusCode
        )
        {
            RequestMessage = httpRequestMessage,
            ResponseMessage = httpResponseMessage,
            //EndPoint = new EndPoint(httpMethod, uri, content)
        };

        throw coinbaseATHttpRequestException;
    }

    private async Task<HttpResponseMessage> SendHttpRequestMessageAsync(
        HttpMethod httpMethod,
        string requestPath,
        string fullRequestPath,
        string contentBody = ""
    )
    {
        var httpRequestMessage = _httpClientService.CreateHttpRequestMessage(
            httpMethod,
            requestPath,
            fullRequestPath,
            contentBody
        );

        var httpResponseMessage = await _httpClientService.HttpClient
            .SendAsync(httpRequestMessage)
            .ConfigureAwait(false);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            return httpResponseMessage;
        }

        var result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

        string message;
        Exception exception = new();

        try
        {
            message = result;
        }
        catch (Exception e)
        {
            exception = e;
            message = contentBody;
        }

        var coinbaseATHttpRequestException = new CoinbaseATHttpRequestException(
            message,
            exception,
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

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        return JsonSerializer.Deserialize<T>(result, options);
    }

    protected async Task<T> SendServiceCall<T>(
        HttpMethod httpMethod,
        string requestPath,
        string fullRequestPath,
        string contentBody = ""
    )
    {
        var httpResponseMessage = await SendHttpRequestMessageAsync(
            httpMethod,
            requestPath,
            fullRequestPath,
            contentBody
        );
        var result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

        if (typeof(T) == typeof(string))
        {
            return (T)(object)result;
        }

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        return JsonSerializer.Deserialize<T>(result, options);
    }
}
