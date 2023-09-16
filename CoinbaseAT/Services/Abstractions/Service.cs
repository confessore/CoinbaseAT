// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using CoinbaseAT.Services.Interfaces;

namespace CoinbaseAT.Services.Abstractions;

public abstract class Service
{
    private protected readonly IHttpClientService _httpClientService;

    protected Service(IHttpClientService httpClientService)
    {
        _httpClientService = httpClientService;
    }
}
