namespace CoinbaseAT.Services.Interfaces;

public interface IAccountsService
{
    Task<IEnumerable<Account>> GetAllAccountsAsync();

    Task<Account> GetAccountByIdAsync(string id);

    Task<IList<IList<AccountHistory>>> GetAccountHistoryAsync(string id, int limit = 100, int numberOfPages = 0);

    Task<IList<IList<AccountHold>>> GetAccountHoldsAsync(string id, int limit = 100, int numberOfPages = 0);
}
