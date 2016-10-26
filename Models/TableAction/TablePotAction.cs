using CoinPokerCommonLib.Models.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class TablePotAction : BaseAction
    {
        public PlayerModel Player { get; set; }
        public decimal Pot { get; set; }
    }
}
