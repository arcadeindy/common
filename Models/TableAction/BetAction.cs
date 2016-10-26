using CoinPokerCommonLib.Models.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class BetAction : BaseAction
    {
        public PlayerModel Player { get; set; }
        public decimal Bet { get; set; }
        public Enums.ActionPokerType Action { get; set; }
    }
}
