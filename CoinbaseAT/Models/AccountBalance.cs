namespace CoinbaseAT.Models;

/// <summary>
/// 
/// </summary>
public class AccountBalance
{
    /// <summary>
    /// Amount of currency that this object represents.
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Denomination of the currency.
    /// </summary>
    public string? Currency { get; set; }
}
