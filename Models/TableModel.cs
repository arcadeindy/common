using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CoinPokerCommonLib.Models;
using System.Collections.ObjectModel;
using CoinPokerCommonLib.Models.Action;
using System.ComponentModel;
using Hik.Communication.ScsServices.Service;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class TableDistributionStats
    {
        public DateTime Started;
        public DateTime Finished;
        public Enums.HandType BestHand;
        public PlayerModel BiggestWin;
    }

    [Serializable]
    public class TableMessageModel
    {
        public enum Status
        {
            SHOW,
            HIDE
        }

        public string Title { get; set; }
        public string Message { get; set; }
    }

    [Serializable]
    [XmlInclude(typeof(PlayerModel))]
    [XmlInclude(typeof(CardModel))]
    [XmlType("TableModel")]
    public class TableModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public decimal Blind { get; set; }

        [XmlIgnore]
        public string Stakes
        {
            get
            {
                return CurrencyFormat.Get(this.Currency, Blind) + "/" + CurrencyFormat.Get(this.Currency, (decimal)(Blind * 2));
            }
        }

        public Enums.LimitType Limit { get; set; }
        public Enums.TableType Type { get; set; }
        public Enums.PokerGameType Game { get; set; }
        public Enums.CurrencyType Currency { get; set; }

        public int ActionTimer { get; set; }

        public int Seats { get; set; } //Ustawia ilość miejsc przy stole

        public int TimeBankOnStart { get; set; }

        [XmlIgnore]
        public TableMessageModel Message { get; set; }

        [XmlIgnore]
        public Object Parent { get; set; } //Rodzic (turniej, gra stołowa)

        [XmlIgnore]
        public decimal AvgPot { get; set; }

        [XmlIgnore]
        public string AvgPotCurrency
        {
            get
            {
                return CurrencyFormat.Get(this.Currency, this.AvgPot);
            }
        }

        [XmlIgnore]
        public int Players { get; set; }

        [XmlIgnore]
        public int Watching { get; set; }

        [XmlIgnore]
        public PlayerModel ActionPlayer { get; set; }

        [XmlIgnore]
        public decimal TablePot { get; set; }

        [XmlIgnore]
        public PlayerModel Dealer { get; set; }

        [XmlIgnore]
        public Enums.Stage Stage { get; set; }

        public TableModel()
        {
            ID = Guid.NewGuid();
            TableCardList = new List<CardModel>();
            ActionHistory = new ObservableCollection<BaseAction>();
            PlayersList = new ObservableCollection<PlayerModel>();
            WatchingList = new ObservableCollection<UserModel>();
        }

        [XmlIgnore]
        public List<CardModel> TableCardList;

        [NonSerialized]
        [XmlArray("ActionHistory")]
        [
        XmlArrayItem(typeof(BetAction)),
        XmlArrayItem(typeof(CardBacksideAction)),
        XmlArrayItem(typeof(CardHideupAction)),
        XmlArrayItem(typeof(CardShowupAction)),
        XmlArrayItem(typeof(CardTableAction)),
        XmlArrayItem(typeof(TablePotAction))
        ]
        public ObservableCollection<BaseAction> ActionHistory;

        [XmlIgnore]
        public string ActionHistoryID { get; set; }

        [NonSerialized]
        [XmlIgnore]
        public ObservableCollection<PlayerModel> PlayersList;

        [NonSerialized]
        [XmlIgnore]
        public ObservableCollection<UserModel> WatchingList;
    }
}
