using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.TournamentOption
{
    [Serializable]
    public class NormalTournamentOptionModel
    {
        public virtual int ID { get; set; }

        public TimeSpan Registration { get; set; }
        public DateTime StartAt { get; set; }
        public TimeSpan LateReg { get; set; }
    }
}
