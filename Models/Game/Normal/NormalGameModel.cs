using CoinPokerCommonLib;
using CoinPokerCommonLib.GameModes;
using CoinPokerCommonLib.Models;
using CoinPokerCommonLib.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    [XmlType("NormalGameModel")]
    [XmlInclude(typeof(TableModel))]
    public class NormalGameModel : BaseGameModel, INormalGameModel
    {
        [XmlIgnore]
        private decimal _min;
        [XmlIgnore]
        public virtual decimal Minimum
        { 
            get{
                if (_min != 0) return _min;
                else return Table.Blind * 2 * 40;
            }
            set{
                _min = value;
            }
        }
        [XmlIgnore]
        private decimal _max;
        [XmlIgnore]
        public virtual decimal Maximum
        {
            get
            {
                if (_max != 0) return _max;
                else return Table.Blind * 2 * 100;
            }
            set
            {
                _max = value;
            }
        }

        public NormalGameModel()
        {

        }

        public virtual int Seats { get; set; }
        public virtual decimal Blind { get; set; }
        public virtual Enums.LimitType Limit { get; set; }
        public virtual Enums.PokerGameType Game { get; set; }
        public virtual Enums.CurrencyType Currency { get; set; }

        public virtual TableModel Table { get; set; }
    }
}
