using System.Collections.Generic;

namespace SteamMarketBridge.Steam.Market
{
    public static class CurrencyDescriptionHelper
	{
        private static readonly List<CurrencyInfo> CurrencyInfos = new List<CurrencyInfo>
		{
            new CurrencyInfo(Currencies.USD, "United States Dollar", "$"),
			new CurrencyInfo(Currencies.GBP, "United Kingdom Pound", "£"),
			new CurrencyInfo(Currencies.EUR, "European Union Euro", "€"),
			new CurrencyInfo(Currencies.CHF, "Swiss Francs", "₣"),
			new CurrencyInfo(Currencies.RUB, "Russian Rouble", "₽"),
			new CurrencyInfo(Currencies.PLN, "Polish Złoty", "zł"),
			new CurrencyInfo(Currencies.BRL, "Brazilian Reals", "R$"),
			new CurrencyInfo(Currencies.JPY, "Japanese Yen", "¥"),
			new CurrencyInfo(Currencies.NOK, "Norwegian Krone", "kr"),
			new CurrencyInfo(Currencies.IDR, "Indonesian Rupiah", "Rp"),
			new CurrencyInfo(Currencies.MYR, "Malaysian Ringgit", "RM"),
			new CurrencyInfo(Currencies.PHP, "Philippine Peso", "₱"),
			new CurrencyInfo(Currencies.SGD, "Singapore Dollar", "S$"),
			new CurrencyInfo(Currencies.THB, "Thai Baht", "฿"),
			new CurrencyInfo(Currencies.VND, "Vietnamese Dong", "₫"),
			new CurrencyInfo(Currencies.KRW, "South Korean Won", "₩"),
			new CurrencyInfo(Currencies.TRY, "Turkish Lira", "₺"),
			new CurrencyInfo(Currencies.UAH, "Ukrainian Hryvnia", "₴"),
			new CurrencyInfo(Currencies.MXN, "Mexican Peso", "Mex$"),
			new CurrencyInfo(Currencies.CAD, "Canadian Dollars", "C$"),
			new CurrencyInfo(Currencies.AUD, "Australian Dollars", "A$"),
			new CurrencyInfo(Currencies.NZD, "New Zealand Dollar", "NZ$"),
			new CurrencyInfo(Currencies.CNY, "Chinese Renminbi (yuan)", "¥"),
			new CurrencyInfo(Currencies.INR, "Indian Rupee", "₹"),
			new CurrencyInfo(Currencies.CLP, "Chilean Peso", "$"),
			new CurrencyInfo(Currencies.PEN, "Peruvian Sol", "S/"),
			new CurrencyInfo(Currencies.COP, "Colombian Peso", "$"),
			new CurrencyInfo(Currencies.ZAR, "South African Rand", "R"),
			new CurrencyInfo(Currencies.HKD, "Hong Kong Dollar", "HK$"),
			new CurrencyInfo(Currencies.TWD, "New Taiwan Dollar", "NT$"),
			new CurrencyInfo(Currencies.SAR, "Saudi Riyal", "﷼"),
			new CurrencyInfo(Currencies.AED, "United Arab Emirates Dirham", "د.إ"),
			new CurrencyInfo(Currencies.SEK, "Swedish Krona", "kr"),
			new CurrencyInfo(Currencies.ARS, "Argentine Peso", "$"),
			new CurrencyInfo(Currencies.ILS, "Israeli New Shekel", "₪"),
			new CurrencyInfo(Currencies.BYN, "Belarusian Ruble", "Br"),
			new CurrencyInfo(Currencies.KZT, "Kazakhstani Tenge", "₸"),
			new CurrencyInfo(Currencies.KWD, "Kuwaiti Dinar", "د.ك"),
			new CurrencyInfo(Currencies.QAR, "Qatari Riyal", "﷼"),
			new CurrencyInfo(Currencies.CRC, "Costa Rican Colón", "₡"),
			new CurrencyInfo(Currencies.UYU, "Uruguayan Peso", "$"),
			new CurrencyInfo(Currencies.BGN, "Bulgarian Lev", "лв"),
			new CurrencyInfo(Currencies.HRK, "Croatian Kuna", "kn"),
			new CurrencyInfo(Currencies.CZK, "Czech Koruna", "Kč"),
			new CurrencyInfo(Currencies.DKK, "Danish Krone", "kr"),
			new CurrencyInfo(Currencies.HUF, "Hungarian Forint", "Ft"),
			new CurrencyInfo(Currencies.RON, "Romanian Leu", "lei")
        };

        public static CurrencyInfo GetCurrencyInfo(Currencies currency)
		{
			return CurrencyInfos[(int)currency - 1];
        }
	}
}