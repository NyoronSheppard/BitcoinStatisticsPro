using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinStatisticsPro.Models
{
    //Update the last value from DataBase
    public static class ValueUpdate
    {
        //Value Btc-e
        public static string valueBtce;

        //Value Crypto Trade
        public static string valueCryptoTrade;

        //Value LocalBitcoins
        public static string valueLocalBitcoins;

        //Value Ripple
        public static string valueRipple;

        //Value Rock Trading
        public static string valueRockTrading;

        //Value Kraken
        public static string valueKraken;

        //Value Bitstamp
        public static string valueBitstamp;

        //Value Bitfinex
        public static string valueBitfinex;

        //Value Camp BX
        public static string valueCampBX;

        //Value BitKonan
        public static string valueBitKonan;

        //Value MtGox
        public static string valueMtGox;

        //Value Justcoin
        public static string valueJustCoin;


        //Symbol
        public static string symbol;

        //Update value list from DataBase
        public static void updateLastValue(string value, string symbol)
        {
            
            if(symbol == "Btc-e")
            {
                valueBtce = value;
            }
            else if(symbol == "Crypto Trade")
            {
                valueCryptoTrade = value;
            }
            else if(symbol == "LocalBitcoins")
            {
                valueLocalBitcoins = value;
            }
            else if(symbol == "Ripple")
            {
                valueRipple = value;
            }
            else if(symbol == "Rock Trading")
            {
                valueRockTrading = value;
            }
            else if(symbol == "Kraken")
            {
                valueKraken = value;
            }
            else if(symbol == "Bitstamp")
            {
                valueBitstamp = value;
            }
            else if(symbol == "Bitfinex")
            {
                valueBitfinex = value;
            }
            else if(symbol == "Camp BX")
            {
                valueCampBX = value;
            }
            else if(symbol == "BitKonan")
            {
                valueBitKonan = value;
            }
            else if(symbol == "MtGox")
            {
                valueMtGox = value;
            }
            else if(symbol == "Justcoin")
            {
                valueJustCoin = value;
            }
        }

        //Get one last value
        public static string getLastValue(string symbol)
        {
            string lastValue = "";

            if (symbol == "Btc-e")
            {
                lastValue = valueBtce;
            }
            else if (symbol == "Crypto Trade")
            {
               lastValue = valueCryptoTrade;
            }
            else if (symbol == "LocalBitcoins")
            {
                lastValue = valueLocalBitcoins;
            }
            else if (symbol == "Ripple")
            {
                lastValue = valueRipple;
            }
            else if (symbol == "Rock Trading")
            {
               lastValue = valueRockTrading;
            }
            else if (symbol == "Kraken")
            {
               lastValue = valueKraken;
            }
            else if (symbol == "Bitstamp")
            {
                lastValue = valueBitstamp;
            }
            else if (symbol == "Bitfinex")
            {
                lastValue = valueBitfinex;
            }
            else if (symbol == "Camp BX")
            {
                lastValue = valueCampBX;
            }
            else if (symbol == "BitKonan")
            {
                lastValue = valueBitKonan;
            }
            else if (symbol == "MtGox")
            {
                lastValue = valueMtGox;
            }
            else if (symbol == "Justcoin")
            {
               lastValue = valueJustCoin;
            }

            return lastValue;
        }
    }
}
