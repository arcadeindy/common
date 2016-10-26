using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CoinPokerCommonLib.Models
{
    [Serializable]
    public class BasePlayerModel
    {
        public UserModel User { get; set; }
        public decimal Stack { get; set; }

        [NonSerialized]
        [XmlIgnore]
        public TableModel Table;

        [XmlIgnore]
        public Enums.CurrencyType Currency
        {
            get
            {
                return this.Table.Currency;
            }
        }

        [XmlIgnore]
        public Guid TableID
        {
            get
            {
                return this.Table.ID;
            }
        }
    }
}
