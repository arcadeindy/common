using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CoinPokerCommonLib.GameModes
{
    /// <summary>
    /// Model bazowy gry
    /// </summary>
    [Serializable]
    [XmlType("BaseGameModel")]
    [XmlInclude(typeof(NormalGameModel))]
    [XmlInclude(typeof(BaseTournamentGameModel))]
    public class BaseGameModel
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }

        public BaseGameModel()
        {

        }
    }
}
