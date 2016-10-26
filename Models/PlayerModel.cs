using CoinPokerCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlInclude(typeof(UserModel))]
    [XmlType("PlayerModel")]
    public class PlayerModel : BasePlayerModel
    {
        public const int AUTO_SEAT = -1;

        [Flags]
        public enum PlayerStatus
        {
            NONE      = 0x0000,
            INGAME    = 0x0001,    //W grze (domyślny) grający przy stole
            WAITING   = 0x0002,   //Dołączył do gry, czeka na nowe rozdanie
            FOLDED    = 0x0004,    //Gracz sfoldował
            DONTPLAY  = 0x0008,  //Nie gra/afk
            LEAVED    = 0x0010,    //Wyszedł z gry przez okno 10 - 20 -40 -80
        }

        public int Seat { get; set; } //Numer siedliska w którym gracz się znajduje
        public int TimeBank { get; set; }        //TimeBank który uruchamia się w wypadku braku akcji o ile jest >0
        public int DontPlayCounter { get; set; } //Licznik braku akcji gdy osiagnie odpowiednia wartosc zmienia status na DONTPLAY
        public PlayerStatus Status { get; set; } //Status gracza

        [NonSerialized]
        [XmlIgnore]
        public List<CardModel> Cards;            //Karty gracza

        public PlayerModel()
        {
            Status = PlayerModel.PlayerStatus.NONE;
            Status |= PlayerModel.PlayerStatus.WAITING;

            DontPlayCounter = 0;
            Cards = new List<CardModel>();
        }
    }
}
