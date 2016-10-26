using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    public class CurrencyFormat
    {
        private static NumberFormatInfo GetFormat(Enums.CurrencyType currency)
        {
            NumberFormatInfo nfi = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            switch (currency)
            {
                case Enums.CurrencyType.VIRTUAL:
                    nfi.CurrencySymbol = "♤";
                    nfi.CurrencyDecimalDigits = 0;
                    return nfi;
                case Enums.CurrencyType.BTC:
                    nfi.CurrencySymbol = "m฿";
                    nfi.CurrencyDecimalDigits = 3;
                    return nfi;
                case Enums.CurrencyType.USD:
                    nfi.CurrencySymbol = "$";
                    nfi.CurrencyDecimalDigits = 2;
                    return nfi;
            }
            return null;
        }

        public static string GetName(Enums.CurrencyType type)
        {
            switch (type)
            {
                case Enums.CurrencyType.VIRTUAL:
                    return "Wirtualne pieniądze";
                case Enums.CurrencyType.USD:
                    return "Dolar amerykański";
                case Enums.CurrencyType.BTC:
                    return "Bitcoin";
                default:
                    return "Nieznany";
            }
        }

        public static string Get(Enums.CurrencyType currency, decimal value)
        {
            return value.ToString("c", GetFormat(currency));
        }
    }


    [Serializable]
    [XmlType("WalletModel")]
    public class WalletModel
    {
        public virtual int ID { get; set; }
        public virtual Enums.CurrencyType Type { get; set; }
        public virtual Decimal Available { get; set; }
        [XmlIgnore]
        public virtual Decimal InGame { get; set; }
        [XmlIgnore]
        public virtual Decimal Sum
        {
            get
            {
                return this.Available + this.InGame;
            }
        }

        public WalletModel()
        {
            TransferList = new List<TransferModel>();
        }

        public override string ToString()
        {
            return CurrencyFormat.GetName(this.Type);
        }

        [NonSerialized]
        public IList<TransferModel> TransferList;

        [NonSerialized]
        public UserModel User;
    }

}
