// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using Microsoft.Extensions.Configuration;
using NuGet.Frameworks;

namespace CoinbaseAT.Test
{
    public class Tests
    {
        private readonly IConfiguration _configuration;
        public Tests()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KeyIsNotNullOrEmpty()
        {
            var key = _configuration["COINBASE_API_KEY"];
            if (!string.IsNullOrEmpty(key))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void SecretIsNotNullOrEmpty()
        {
            var key = _configuration["COINBASE_API_SECRET"];
            if (!string.IsNullOrEmpty(key))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public async Task ProductReturns200()
        {
            var configuration = new CoinbaseATConfiguration(_configuration["COINBASE_API_KEY"], _configuration["COINBASE_API_SECRET"]);
            var client = new CoinbaseATClient(configuration);
            var productResponse = await client.ProductsService.GetProductAsync("BTC-USD");
            if (string.IsNullOrEmpty(productResponse.Product_Id))
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public async Task AccountsReturns200()
        {
            var configuration = new CoinbaseATConfiguration(_configuration["COINBASE_API_KEY"], _configuration["COINBASE_API_SECRET"]);
            var client = new CoinbaseATClient(configuration);
            var accountsResponse = await client.AccountsService.ListAccountsAsync();
            foreach (var account in accountsResponse.Accounts)
            {
                Console.WriteLine(account.Uuid);
            }
        }
    }
}
