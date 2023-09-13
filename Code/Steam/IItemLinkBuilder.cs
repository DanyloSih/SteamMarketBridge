namespace SteamMarketBridge.Steam.Market
{
    public interface IItemLinkBuilder
    {
        /// <param name="itemName">Name of the item on the steam market page.
        /// Can usually be found in the target item link. <br/>
        /// For example in this link: <br/>
        /// https://steamcommunity.com/market/listings/730/AK-47 | Slate (Field-Tested) <br/>
        /// "AK-47 | Slate (Field-Tested)" - this is item name. <br/>
        /// </param>
        string Build(string itemName);
    }
}