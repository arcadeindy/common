using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models
{
    [Serializable]
    public class TournamentPlayerModel
    {
        /// <summary>
        /// Model gracza
        /// </summary>
        public PlayerModel Player { get; set; }

        /// <summary>
        /// Zajęte miejsce
        /// </summary>
        public int PlaceID { get; set; }

        /// <summary>
        /// Status zetonowy gracza
        /// </summary>
        public string TournamentStackStatus
        {
            get
            {
                if (Player.Stack == 0.0m)
                {
                    return "Zakończył";
                }
                else
                {
                    return Player.Stack.ToString();
                }
            }
        }

    }
}
