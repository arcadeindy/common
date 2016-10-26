using CoinPokerCommonLib;
using CoinPokerCommonLib.GameModes;
using CoinPokerCommonLib.Models;
using CoinPokerCommonLib.Models.Game.Tournament.WinningPotModel;
using CoinPokerCommonLib.Models.Game.TournamentOption;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlType("TournamentGameModel")]
    [XmlInclude(typeof(TableModel))]
    public class BaseTournamentGameModel : BaseGameModel
    {
        /// <summary>
        /// Waluta kwoty wejściowej 
        /// </summary>
        public Enums.CurrencyType EntryCurrency { get; set; }

        /// <summary>
        /// Kwota wejściowa do turnieju
        /// </summary>
        public decimal EntryPayment { get; set; } //Kwota wejściowa
        public string EntryPaymentCurrency
        {
            get
            {
                return CurrencyFormat.Get(this.EntryCurrency, EntryPayment);
            }
        }

        /// <summary>
        /// Maksymalna ilośc graczy uczestnicząca w turnieju
        /// </summary>
        public int MaxPlayers { get; set; } //Max ilośc graczy w turnieju
        /// <summary>
        /// Ilość zarejestrowanych graczy
        /// </summary>
        public int Registered { get; set; } //Obecna ilosc zarejestrowanych

        /// <summary>
        /// Kwota gwarantowana w turnieju
        /// </summary>
        public decimal WinPotGuaranteed { get; set; }

        /// <summary>
        /// Kwota wygranej z kwotą gwarantowaną
        /// </summary>
        private decimal winpot;
        public decimal WinPot
        {
            get
            {
                return winpot + WinPotGuaranteed;
            }
            set
            {
                winpot = value;
            }
        }

        public string WinPotCurrency
        {
            get
            {
                return CurrencyFormat.Get(this.EntryCurrency, WinPot);
            }
        }

        /// <summary>
        /// Typ rozdzielania wygranej
        /// </summary>
        public Enums.TournamentPrizeType PrizeType { get; set; }

        /// <summary>
        /// Stan turnieju
        /// </summary>
        public Enums.TournamentState State { get; set; }

        /// <summary>
        /// Co jaki okres zmienia się poziom
        /// </summary>
        public int NextLevelTime { get; set; } //Co jaki okres wzrasta poziom (s)
        
        /// <summary>
        /// Aktualny poziom turnieju
        /// </summary>
        public int Level { get; set; } //Aktualny poziom

        /// <summary>
        /// Startowa suma żetonow
        /// </summary>
        public decimal StartStack { get; set; } //Początkowy stack każdego gracza

        public BaseTournamentGameModel()
        {
            TableList = new List<TableModel>();
            PlayersList = new ObservableCollection<TournamentPlayerModel>();
            State = Enums.TournamentState.Announced;
            PrizeType = Enums.TournamentPrizeType.STATIC;

            StartStack = 1500;
            NextLevelTime = 120;
            Level = 1;
        }

        [NonSerialized]
        [XmlIgnore]
        public List<TableModel> TableList;

        [NonSerialized]
        [XmlIgnore]
        public ObservableCollection<TournamentPlayerModel> PlayersList; //gracze którzy dołączyli do turnieju
    }
}
