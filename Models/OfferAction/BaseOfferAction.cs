using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.OfferAction
{
    [Serializable]
    public class BaseOfferAction : IOfferAction
    {
        public DateTime Timestamp { get; set; }
    }
}
