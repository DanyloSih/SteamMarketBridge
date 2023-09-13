namespace SteamMarketBridge.Steam.Market.CSGO
{
    public class CSGOItemLinkBuilder : IItemLinkBuilder
    {
        public string Build(string itemName)
            => $"https://steamcommunity.com/market/listings/730/{itemName}";
    }
}