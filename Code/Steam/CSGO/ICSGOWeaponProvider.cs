namespace SteamMarketBridge.Steam.Market.CSGO
{
    public interface ICSGOWeaponProvider
    {
        /// <summary>
        /// Returns complete data about a specific skin from an inspection link.
        /// </summary>
        /// <param name="inspectionLink">Link where you can view the skin in the game. <br/>
        /// Like this: <br/> 
        /// steam://rungame/730/76561202255233023/+csgo_econ_action_preview%20M4317318352633508391A33177717440D2945405620321184539</param>
        public CSGOWeapon GetWeapon(string inspectionLink);
    }

    public class CSGOFloatWeaponProvider : ICSGOWeaponProvider
    {
        private string _ipAndPort;

        /// <param name="ipAndPort">
        /// IP and port for accessing the csgofloat service, for example: "133.214.108.47:4545". <br/>
        /// If csgofloat is running locally, then you can pass "localhost".
        /// </param>
        public CSGOFloatWeaponProvider(string ipAndPort)
        {
            _ipAndPort = ipAndPort;
        }

        public CSGOWeapon GetWeapon(string inspectionLink)
        {
            string requestUrl = $"http://{_ipAndPort}/?url={inspectionLink}";
            return new CSGOWeapon();
        }
    }
}