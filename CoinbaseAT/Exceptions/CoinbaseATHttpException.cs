// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Net;

namespace CoinbaseAT.Exceptions;

public class CoinbaseATHttpRequestException : HttpRequestException
{
    public HttpRequestMessage? RequestMessage { get; set; }

    public HttpResponseMessage? ResponseMessage { get; set; }

    public CoinbaseATHttpRequestException()
    {
    }

    public CoinbaseATHttpRequestException(string message)
        : base(message)
    {
    }

    public CoinbaseATHttpRequestException(string message, Exception inner)
        : base(message, inner)
    {
    }
    public CoinbaseATHttpRequestException(string message, Exception inner, HttpStatusCode httpStatusCode)
        : base(message, inner, httpStatusCode)
    {
    }
}
