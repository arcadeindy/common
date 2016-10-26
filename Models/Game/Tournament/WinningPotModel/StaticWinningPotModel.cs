using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.Tournament.WinningPotModel
{
    public class StaticWinningPotModel : IWinningPotModel
    {
        /// <summary>
        /// Liczba osób które otrzymają nagrodę
        /// </summary>
        private BaseTournamentGameModel TournamentModel { get; set; }

        public StaticWinningPotModel(BaseTournamentGameModel tournamentModel)
        {
            TournamentModel = tournamentModel;
        }

        public List<WinningPot> PrizeCalc()
        {
            var list = new List<WinningPot>();

            if (TournamentModel.WinPotGuaranteed == 0.0m && TournamentModel.Registered < 3) return list;

            list.Add(new WinningPot(){
                PlaceID = 1,
                Prize = (decimal)(TournamentModel.WinPot * 0.5m)
            });
            list.Add(new WinningPot()
            {
                PlaceID = 2,
                Prize = (decimal)(TournamentModel.WinPot * 0.35m)
            });
            
            list.Add(new WinningPot()
            {
                PlaceID = 3,
                Prize = (decimal)(TournamentModel.WinPot * 0.15m)
            });

            return list;
        }
    }
}
