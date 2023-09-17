// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net.Http.Headers;
using CoinbaseAT.Interfaces;
using CoinbaseAT.Services;
using CoinbaseAT.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoinbaseAT;

/// <summary>
/// <inheritdoc cref="ICoinbaseATClient"/>
/// </summary>
public class CoinbaseATClient : ICoinbaseATClient
{
    private readonly ServiceProvider _serviceProvider;

    public CoinbaseATClient(ICoinbaseATConfiguration coinbaseATConfiguration)
    {
        _serviceProvider = ConfigureServices(coinbaseATConfiguration);
        AccountsService = _serviceProvider.GetRequiredService<IAccountsService>();
        FeesService = _serviceProvider.GetRequiredService<IFeesService>();
        OrdersService = _serviceProvider.GetRequiredService<IOrdersService>();
        ProductsService = _serviceProvider.GetRequiredService<IProductsService>();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IAccountsService AccountsService { get; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IFeesService FeesService { get; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IOrdersService OrdersService { get; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IProductsService ProductsService { get; }

    private static ServiceProvider ConfigureServices(
        ICoinbaseATConfiguration coinbaseATConfiguration
    )
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton(coinbaseATConfiguration);
        serviceCollection.AddHttpClient<IHttpClientService, HttpClientService>(
            nameof(IHttpClientService),
            options =>
            {
                options.BaseAddress = new Uri("https://api.coinbase.com");
                options.DefaultRequestHeaders.Add("User-Agent", "CoinbaseATClient");
                options.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );
                options.DefaultRequestHeaders.Add("CB-ACCESS-KEY", coinbaseATConfiguration.APIKey);
            }
        );
        serviceCollection.AddSingleton<IHttpClientService, HttpClientService>();
        serviceCollection.AddSingleton<IAccountsService, AccountsService>();
        serviceCollection.AddSingleton<IFeesService, FeesService>();
        serviceCollection.AddSingleton<IOrdersService, OrdersService>();
        serviceCollection.AddSingleton<IProductsService, ProductsService>();
        return serviceCollection.BuildServiceProvider();
    }
}
