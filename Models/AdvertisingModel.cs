using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models
{
    [Serializable]
    public class AdvertisingModel
    {
        public virtual int ID { get; set; }
        public virtual string Url { get; set; }
        public virtual string Image { get; set; }
    }
}
