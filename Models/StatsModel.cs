using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlType("StatsModel")]
    public class StatsModel
    {
        public int UsersOnline { get; set; }
        public decimal InGameMoney { get; set; }
        public DateTime ServerTime { get; set; }
        public int TablesToPlay { get; set; }
    }
}
