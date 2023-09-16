// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Interfaces;

public interface ICoinbaseATConfiguration
{
    string APIKey { get; }

    string APISecret { get; }
    string ComputeSignature(
        HttpMethod methpd,
        string secret,
        double timestamp,
        string requestPath,
        string body = ""
    );
}
