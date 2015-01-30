using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinStatisticsPro.Models
{
    class BitcoinCharts
    {
        public double volume { get; set; }
        public int latest_trade { get; set; }
        public double bid { get; set; }
        public double high { get; set; }
        public string currency { get; set; }
        public double currency_volume { get; set; }
        public double ask { get; set; }
        public double close { get; set; }
        public double avg { get; set; }
        public string symbol { get; set; }
        public double low { get; set; }
    }
}
