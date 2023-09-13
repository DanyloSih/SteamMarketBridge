using System.Collections.Generic;

namespace SteamMarketBridge.Steam.Market.CSGO
{
    public struct CSGOWeapon : ISteamMarketItem
	{
		public struct SkinData
		{
            /// <summary>
            /// Exterior wear of the skin in its float representation.
            /// </summary>
            public float Float { get; private set; }
            /// <summary>
            /// Seed for the RNG that defines how to place the skin texture.
            /// </summary>
            public int PaintSeed { get; private set; }
            /// <summary>
            /// Paint ID of the weapon (skin).
            /// </summary>
            public int PaintIndex { get; private set; }
			public IReadOnlyList<CSGOSticker> Stickers { get; private set; }
		}

        /// <param name="marketLink">Link to the page of the steam market where this item can be purchased.</param>
        /// <param name="inspectionLink">
        /// Link where you can view the skin in the game. <br/>
        /// Like this: steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4317318352633508391A33177717440D2945405620321184539</param>
        /// <param name="name"></param>
        /// <param name="gameId"></param>
        /// <param name="listingID"></param>
        /// <param name="assetID"></param>
        /// <param name="dParameter"></param>
        /// <param name="priceWithFee"></param>
        /// <param name="currencyInfo"></param>
        public CSGOWeapon(string marketLink, string inspectionLink, string name, int gameId, string listingID, string assetID, string dParameter, float priceWithFee, CurrencyInfo currencyInfo)
        {
            MarketLink = marketLink;
            InspectionLink = inspectionLink;
            Name = name;
            GameId = gameId;
            ListingID = listingID;
            AssetID = assetID;
            DParameter = dParameter;
            PriceWithFee = priceWithFee;
            CurrencyInfo = currencyInfo;
        }

        public string MarketLink { get; private set; }
        /// <summary>
        /// Link where you can view the skin in the game. <br/>
        /// Like this: steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4317318352633508391A33177717440D2945405620321184539
        /// </summary>
		public string InspectionLink { get; private set; }
		public string Name { get; private set; }
		public int GameId { get; private set; }
		/// <summary>
		/// Also known as the (First) M parameter in the in-game inspection link.
		/// </summary>
		public string ListingID { get; private set; }
		/// <summary>
		/// Also known as the (Second) A parameter in the in-game inspection link.
		/// </summary>
		public string AssetID { get; private set; }
		/// <summary>
		/// The last (Third) parameter of the in-game inspection link.
		/// </summary>
		public string DParameter { get; private set; }
        public float PriceWithFee { get; private set; }
        public CurrencyInfo CurrencyInfo { get; private set; }
    }
}