// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using System.Collections.Generic;
using CoinbaseAT.Models.Interfaces;

namespace CoinbaseAT.Models;

/// <summary>
/// <inheritdoc cref="IProduct"/>
/// </summary>
public class Product : IProduct
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price_Percentage_Change_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Volume_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Volume_Percentage_Change_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Min_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Max_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Min_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Max_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Name { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Name { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Watched { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Is_Disabled { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? New { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Cancel_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Limit_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Post_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Trading_Disabled { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? Auction_Mode { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Product_Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Currency_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Currency_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FCMTradingSessionDetails? FCM_Trading_Session_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Mid_Market_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Alias { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<string>? Alias_To { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Base_Display_Symbol { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Quote_Display_Symbol { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool? View_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Price_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FutureProductDetails? Future_Product_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string? Contract_Display_Name { get; set; }
#elif NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Product_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Price_Percentage_Change_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Volume_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Volume_Percentage_Change_24H { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Min_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Max_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Min_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Max_Size { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Name { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Name { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Watched { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Is_Disabled { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool New { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Cancel_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Limit_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Post_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Trading_Disabled { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool Auction_Mode { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Product_Type { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Currency_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Currency_Id { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FCMTradingSessionDetails FCM_Trading_Session_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Mid_Market_Price { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Alias { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IEnumerable<string> Alias_To { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Base_Display_Symbol { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Quote_Display_Symbol { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool View_Only { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Price_Increment { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public FutureProductDetails Future_Product_Details { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public string Contract_Display_Name { get; set; }
#endif
}
