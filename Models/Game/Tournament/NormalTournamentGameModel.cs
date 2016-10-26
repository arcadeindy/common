using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.TournamentOption
{
    [Serializable]
    public class NormalTournamentGameModel : NormalTournamentOptionModel, ITournamentGameModel
    {
        public BaseTournamentGameModel TournamentModel { get; set; }

        public NormalTournamentGameModel()
        {
        }

        public void Update()
        {
            
        }

        public bool IsStarted()
        {
            return (DateTime.Now <= StartAt);
        }

        public string StartString
        {
            get
            {
                return StartAt.ToString();
            }
            set
            {

            }
        }


        public string GetTypeString
        {
            get {
                return "Normalny";
            }
        }
    }
}
