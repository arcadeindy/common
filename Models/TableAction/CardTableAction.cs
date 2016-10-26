using CoinPokerCommonLib.Models.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class CardTableAction : BaseAction
    {
        public List<CardModel> Cards { get; set; }
    }
}
