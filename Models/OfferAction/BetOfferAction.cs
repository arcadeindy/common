using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.OfferAction
{
    [Serializable]
    public class BetOfferAction : BaseOfferAction
    {
        public PlayerModel Player { get; set; }
        public decimal MinBet { get; set; }
        public decimal MaxBet { get; set; }
        public decimal BetTick { get; set; }
        public int Time { get; set; }
        public decimal LastBet { get; set; }
    }
}
