using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.TournamentOption
{
    [Serializable]
    public class SitAndGoTournamentGameModel : SitAndGoTournamentOptionModel, ITournamentGameModel
    {
        public BaseTournamentGameModel TournamentModel { get; set; }

        public SitAndGoTournamentGameModel()
        {
        }

        public void Update()
        {

        }

        public bool IsStarted()
        {
            //Musimy uzyc registtered poniewaz korzysta z tego takze klient
            return (TournamentModel.Registered == TournamentModel.MaxPlayers);
        }

        public string StartString
        {
            get
            {
                return "Sit & Go";
            }
            set
            {

            }
        }

        public string GetTypeString
        {
            get
            {
                return "Sit&Go";
            }
        }
    }
}
