using System.Collections.Generic;
using SteamMarketBridge.Steam.Market.CSGO;

namespace SteamMarketBridge.Steam.Market
{

    public class SteamMarketUser
	{
        /// <summary>
        /// Returns a list of items from the CS GO weapon page in the Steam market.
        /// </summary>
        /// <param name="itemName">Name of the item on the steam market page.
        /// Can usually be found in the target item link. <br/>
        /// For example in this link: <br/>
        /// https://steamcommunity.com/market/listings/730/AK-47 | Slate (Field-Tested) <br/>
        /// "AK-47 | Slate (Field-Tested)" - this is item name. <br/>
        /// </param>
        /// <param name="startItemId">Defines the number of elements from the 
        /// beginning that will be skipped during parsing. <br/>
        /// For example: <br/>
        /// 0 - first page <br/>
        /// 10 - second page <br/>
        /// 20 - third page</param>
        /// <param name="itemsCount">Maximum value is 100! Determines how many elements will be parsed.</param>
        public List<CSGOWeapon> ParseCSGOItemsByName(string itemName, int startItemId = 0, int itemsCount = 100)
		{
            return new List<CSGOWeapon>();
		}
	}
}