namespace CoinbaseAT.Models;

/// <summary>
/// 
/// </summary>
public class Account
{
    /// <summary>
    /// Unique identifier for account.
    /// </summary>
    public string? Uuid { get; set; }

    /// <summary>
    /// Name for the account.
    /// </summary>
    public string? ProfileId { get; set; }

    /// <summary>
    /// Currency symbol for the account.
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public AccountBalance? Available_Balance { get; set; }

    /// <summary>
    /// Whether or not this account is the user's primary account.
    /// </summary>
    public bool Default { get; set; }

    /// <summary>
    /// Whether or not this account is active and okay to use.
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Time at which this account was created.
    /// </summary>
    public DateTime Created_At { get; set; }

    /// <summary>
    /// Time at which this account was updated.
    /// </summary>
    public DateTime Updated_At { get; set; }

    /// <summary>
    /// Time at which this account was deleted.
    /// </summary>
    public DateTime Deleted_At { get; set; }

    /// <summary>
    /// Possible values: [ACCOUNT_TYPE_UNSPECIFIED, ACCOUNT_TYPE_CRYPTO, ACCOUNT_TYPE_FIAT, ACCOUNT_TYPE_VAULT]
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Whether or not this account is ready to trade.
    /// </summary>
    public bool Ready { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public AccountHold? Hold { get; set; }
}
