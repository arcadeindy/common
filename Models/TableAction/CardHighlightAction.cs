using CoinPokerCommonLib.Models.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class CardHighlightAction : BaseAction
    {
        public List<CardModel> Cards { get; set; }
        public PlayerModel Player { get; set; }
    }
}
