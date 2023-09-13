namespace SteamMarketBridge.Steam.Market
{
    public struct CurrencyInfo
    {
        public Currencies Currency { get; private set; }
        public string Description { get; private set; }
        public string CurrencySymbol { get; private set; }

        public CurrencyInfo(Currencies currency, string description, string currencySymbol)
        {
            Currency = currency;
            Description = description;
            CurrencySymbol = currencySymbol;
        }
    }
}