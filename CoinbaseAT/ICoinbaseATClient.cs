namespace CoinbaseAT;

public interface ICoinbaseATClient
{
    IAccountsService AccountsService { get; }

    ICoinbaseAccountsService CoinbaseAccountsService { get; }

    IOrdersService OrdersService { get; }

    IPaymentsService PaymentsService { get; }

    IWithdrawalsService WithdrawalsService { get; }

    IDepositsService DepositsService { get; }

    IProductsService ProductsService { get; }

    ICurrenciesService CurrenciesService { get; }

    IFillsService FillsService { get; }

    IFeesService FeesService { get; }

    IFundingsService FundingsService { get; }

    IReportsService ReportsService { get; }

    IUserAccountService UserAccountService { get; }

    IStablecoinConversionsService StablecoinConversionsService { get; }

    IWebSocket WebSocket { get; }

    IProfilesService ProfilesService { get; }

    ILimitsService LimitsService { get; }
}
