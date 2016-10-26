using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class TransferModel
    {
        public virtual int ID { get; set; }
        public virtual Enums.TransferType Type { get; set; }
        public virtual Decimal Amount { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual string Comment { get; set; }
        public virtual string Flag { get; set; }

        public virtual Enums.CurrencyType Currency { get; set; }
        public virtual decimal WalletAmountBefore { get; set; }

        [NonSerialized]
        public WalletModel Wallet;
    }

}
