using CoinPokerCommonLib.GameModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlType("UserModel")]
    [XmlInclude(typeof(PlayerModel))]
    public class UserModel
    {
        public virtual int ID { get; set; }
        public virtual string Username { get; set; }
        private string _avatarUpdate;

        public virtual DateTime LastLogin { get; set; }
        public virtual DateTime DateJoined { get; set; }
        public bool IsSuperuser { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public virtual string Avatar
        {
            get
            {
                return "http://www.unitypoker.eu/account/get_avatar/" + this.Username + "/?"+_avatarUpdate;
            }

            set
            {
                _avatarUpdate = DateTime.Now.Ticks.ToString();
            }
        }

        [NonSerialized]
        public string Password;

        public UserModel()
        {
            WalletList = new List<WalletModel>();
            //LikeList = new List<BaseGameModel>();
        }

        /// <summary>
        /// Lista portfeli użytkownika
        /// </summary>
        [NonSerialized]
        [XmlArray("WalletList")]
        [
        XmlArrayItem(typeof(WalletModel))
        ]
        public List<WalletModel> WalletList;

        /// <summary>
        /// Lista ulubionych stołów
        /// </summary>

        /*
         * TODO: Dodac klase Like przechowujaca identyfikator i typ obiektu
         * [NonSerialized]
        [XmlArray("LikeList")]
        [
        XmlArrayItem(typeof(NormalGameModel)),
        XmlArrayItem(typeof(TournamentGameModel)),
        ]
        public List<BaseGameModel> LikeList;*/

    }
}
