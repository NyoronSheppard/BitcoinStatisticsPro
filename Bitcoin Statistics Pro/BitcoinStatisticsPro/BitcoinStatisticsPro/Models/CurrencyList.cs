using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinStatisticsPro.Models
{

    //Convert symbol in string
    public class CurrencyList
    {
        private List<string> names = new List<string>();

        public CurrencyList()
        {
            this.names.Add("Btc-e");
            this.names.Add("Crypto Trade");
            this.names.Add("LocalBitcoins");
            this.names.Add("Ripple");
            this.names.Add("Rock Trading");
            this.names.Add("Kraken");
            this.names.Add("Bitstamp");
            this.names.Add("Bitfinex");
            this.names.Add("Camp BX");
            this.names.Add("BitKonan");
            this.names.Add("MtGox");
            this.names.Add("Justcoin");
        }

        public string convertSymbolToString(string symbol)
        {
            string retur = "";

            if(symbol == "btceUSD")
            {
                retur = this.names[0];
            }
            else if(symbol == "crytrUSD")
            {
                retur = this.names[1];
            }
            else if(symbol == "localbtcUSD")
            {
                retur = this.names[2];
            }
            else if(symbol == "rippleUSD")
            {
                retur = this.names[3];
            }
            else if(symbol == "rockUSD")
            {
                retur = this.names[4];
            }
            else if(symbol == "krakenUSD")
            {
                retur = this.names[5];
            }
            else if(symbol == "bitstampUSD")
            {
                retur = this.names[6];
            }
            else if(symbol == "bitfinexUSD")
            {
                retur = this.names[7];
            }
            else if(symbol == "cbxUSD")
            {
                retur = this.names[8];
            }
            else if(symbol == "bitkonanUSD")
            {
                retur = this.names[9];
            }
            else if (symbol == "mtgoxUSD")
            {
                retur = this.names[10];
            }
            else if (symbol == "justUSD")
            {
                retur = this.names[11];
            }

            return retur;

        }
    }

    
}
