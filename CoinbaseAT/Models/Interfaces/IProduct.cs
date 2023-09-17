// Copyright (c) Steven Confessore - Balanced Solutions Software - CoinbaseAT Contributors.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace CoinbaseAT.Models.Interfaces;

/// <summary>
///
/// </summary>
public interface IProduct
{
    /// <summary>
    /// The trading pair.
    /// </summary>
    public string? Product_Id { get; set; }

    /// <summary>
    /// The current price for the product, in quote currency.
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// The amount the price of the product has changed, in percent, in the last 24 hours.
    /// </summary>
    public string? Price_Percentage_Change_24H { get; set; }

    /// <summary>
    /// The trading volume for the product in the last 24 hours.
    /// </summary>
    public string? Volume_24H { get; set; }

    /// <summary>
    /// The percentage amount the volume of the product has changed in the last 24 hours.
    /// </summary>
    public string? Volume_Percentage_Change_24H { get; set; }

    /// <summary>
    /// Minimum amount base value can be increased or decreased at once.
    /// </summary>
    public string? Base_Increment { get; set; }

    /// <summary>
    /// Minimum amount quote value can be increased or decreased at once.
    /// </summary>
    public string? Quote_Increment { get; set; }

    /// <summary>
    /// Minimum size that can be represented of quote currency.
    /// </summary>
    public string? Quote_Min_Size { get; set; }

    /// <summary>
    /// Maximum size that can be represented of quote currency.
    /// </summary>
    public string? Quote_Max_Size { get; set; }

    /// <summary>
    /// Minimum size that can be represented of base currency.
    /// </summary>
    public string? Base_Min_Size { get; set; }

    /// <summary>
    /// Maximum size that can be represented of base currency.
    /// </summary>
    public string? Base_Max_Size { get; set; }

    /// <summary>
    /// Name of the base currency.
    /// </summary>
    public string? Base_Name { get; set; }

    /// <summary>
    /// Name of the quote currency.
    /// </summary>
    public string? Quote_Name { get; set; }

    /// <summary>
    /// Whether or not the product is on the user's watchlist.
    /// </summary>
    public bool? Watched { get; set; }

    /// <summary>
    /// Whether or not the product is disabled for trading.
    /// </summary>
    public bool? Is_Disabled { get; set; }

    /// <summary>
    /// Whether or not the product is 'new'.
    /// </summary>
    public bool? New { get; set; }

    /// <summary>
    /// Status of the product.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Whether or not orders of the product can only be cancelled, not placed or edited.
    /// </summary>
    public bool? Cancel_Only { get; set; }

    /// <summary>
    /// Whether or not orders of the product can only be limit orders, not market orders.
    /// </summary>
    public bool? Limit_Only { get; set; }

    /// <summary>
    /// Whether or not orders of the product can only be posted, not cancelled.
    /// </summary>
    public bool? Post_Only { get; set; }

    /// <summary>
    /// Whether or not the product is disabled for trading for all market participants.
    /// </summary>
    public bool? Trading_Disabled { get; set; }

    /// <summary>
    /// Whether or not the product is in auction mode.
    /// </summary>
    public bool? Auction_Mode { get; set; }

    /// <summary>
    /// Possible values: [SPOT, FUTURE]
    /// </summary>
    public string? Product_Type { get; set; }

    /// <summary>
    /// Symbol of the quote currency.
    /// </summary>
    public string? Quote_Currency_Id { get; set; }

    /// <summary>
    /// Symbol of the base currency.
    /// </summary>
    public string? Base_Currency_Id { get; set; }

    /// <summary>
    ///
    /// </summary>
    public FCMTradingSessionDetails? FCM_Trading_Session_Details { get; set; }

    /// <summary>
    /// The current midpoint of the bid-ask spread, in quote currency.
    /// </summary>
    public string? Mid_Market_Price { get; set; }

    /// <summary>
    /// Product id for the corresponding unified book.
    /// </summary>
    public string? Alias { get; set; }

    /// <summary>
    /// Product ids that this product serves as an alias for.
    /// </summary>
    public IEnumerable<string>? Alias_To { get; set; }

    /// <summary>
    /// Symbol of the base display currency.
    /// </summary>
    public string? Base_Display_Symbol { get; set; }

    /// <summary>
    /// Symbol of the quote display currency.
    /// </summary>
    public string? Quote_Display_Symbol { get; set; }

    /// <summary>
    /// Whether or not the product is in view only mode.
    /// </summary>
    public bool? View_Only { get; set; }

    /// <summary>
    /// Minimum amount price can be increased or decreased at once.
    /// </summary>
    public string? Price_Increment { get; set; }

    /// <summary>
    ///
    /// </summary>
    public FutureProductDetails? Future_Product_Details { get; set; }

    /// <summary>
    ///
    /// </summary>
    public string? Contract_Display_Name { get; set; }
}
