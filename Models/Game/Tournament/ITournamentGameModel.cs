using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.TournamentOption
{
    public interface ITournamentGameModel : IGameModel
    {
        void Update();
        bool IsStarted();
        string StartString { get; set; }

        string GetTypeString
        {
            get;
        }

        BaseTournamentGameModel TournamentModel { get; set; }
    }
}
