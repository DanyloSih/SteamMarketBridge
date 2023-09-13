namespace SteamMarketBridge.Steam.Market
{
    public interface ISteamMarketItem
	{
        /// <summary>
        /// Item name on the steam market
        /// </summary>
        string Name { get; }
        /// <summary>
        /// ID of the game to which the item belongs.
        /// </summary>
        int GameId { get; }
        /// <summary>
        /// Link to the page of the steam market where this item can be purchased.
        /// </summary>
		string MarketLink { get; }
        /// <summary>
        /// The price at which you could purchase this product.
        /// </summary>
		float PriceWithFee { get; }
        /// <summary>
        /// Information about the currency in which the price was received.
        /// </summary>
		CurrencyInfo CurrencyInfo { get; }
	}
}