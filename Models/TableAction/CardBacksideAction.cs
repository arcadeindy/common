using CoinPokerCommonLib.Models.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class CardBacksideAction : BaseAction
    {
        public PlayerModel Player { get; set; }
        public int Count { get; set; }
    }
}
