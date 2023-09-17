// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System;

namespace CoinbaseAT.Extensions;

public static class DateTimeExtensions
{
    public static double ToTimestamp(this DateTime dateTime) =>
        (dateTime - DateTime.UnixEpoch).TotalSeconds;
}
