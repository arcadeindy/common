using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlType("CardModel")]
    public class CardModel
    {
        public enum CardSuit
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }

        public enum CardNominalValue
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public CardSuit Suit { get; set; }
        public CardNominalValue Face { get; set; }

        public enum NormalizeNominalSize
        {
            ONE,
            MANY
        }

        public static string GetNormalize(CardModel model, NormalizeNominalSize size)
        {
            return GetNormalizeNominal(model.Face, size) + " " + GetNormalizeSuit(model.Suit);
        }

        public static string GetNormalizeNominal(CardNominalValue value, NormalizeNominalSize size)
        {
            switch (value)
            {
                case CardNominalValue.Ace:
                    return (size == NormalizeNominalSize.ONE) ? "as" : "asy";
                case CardNominalValue.King:
                    return (size == NormalizeNominalSize.ONE) ? "król" : "króle";
                case CardNominalValue.Queen:
                    return (size == NormalizeNominalSize.ONE) ? "dama" : "damy";
                case CardNominalValue.Jack:
                    return (size == NormalizeNominalSize.ONE) ? "walet" : "walety";
                case CardNominalValue.Ten:
                    return (size == NormalizeNominalSize.ONE) ? "dziesiątka" : "dziesiątki";
                case CardNominalValue.Nine:
                    return (size == NormalizeNominalSize.ONE) ? "dziewiątka" : "dziewiątki";
                case CardNominalValue.Eight:
                    return (size == NormalizeNominalSize.ONE) ? "ósemka" : "ósemki";
                case CardNominalValue.Seven:
                    return (size == NormalizeNominalSize.ONE) ? "siódemka" : "siódemki";
                case CardNominalValue.Six:
                    return (size == NormalizeNominalSize.ONE) ? "szóstka" : "szóstki";
                case CardNominalValue.Five:
                    return (size == NormalizeNominalSize.ONE) ? "piątka" : "piątki";
                case CardNominalValue.Four:
                    return (size == NormalizeNominalSize.ONE) ? "czwórka" : "czwórki";
                case CardNominalValue.Three:
                    return (size == NormalizeNominalSize.ONE) ? "trójka" : "trójki";
                case CardNominalValue.Two:
                    return (size == NormalizeNominalSize.ONE) ? "dwójka" : "dwójki";
                default :
                    return "Błąd";
            }
        }

        public static string GetNormalizeSuit(CardSuit suit)
        {
            switch (suit){
                case CardSuit.Clubs:
                    return "trefl";
                case CardSuit.Diamonds:
                    return "karo";
                case CardSuit.Hearts:
                    return "kier";
                case CardSuit.Spades:
                    return "pik";
                default:
                    return "Błąd";
            }
        }
    }
}
