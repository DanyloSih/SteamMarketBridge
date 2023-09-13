namespace SteamMarketBridge.Steam.Market.CSGO
{
    public struct CSGOSticker : ISteamMarketItem
    {
        public string Name { get; private set; }
        public int GameId { get; private set; }
        public string MarketLink { get; private set; }
        public float PriceWithFee { get; private set; }
        public CurrencyInfo CurrencyInfo { get; private set; }
		public int StickerId { get; private set; }
        /// <summary>
        /// The slot number on the weapon model where the sticker is located.
        /// </summary>
        public int Slot { get; private set; }
    }
}