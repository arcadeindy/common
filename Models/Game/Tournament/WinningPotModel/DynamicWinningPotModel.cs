using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.Tournament.WinningPotModel
{

    public class DynamicWinningPotModel : IWinningPotModel
    {
        /// <summary>
        /// Liczba osób które otrzymają nagrodę
        /// </summary>
        public float LastPrize { get; set; }

        public int TotalPrize { get; set; }

        private BaseTournamentGameModel TournamentModel { get; set; }

        public DynamicWinningPotModel(BaseTournamentGameModel tournamentModel)
        {
            TournamentModel = tournamentModel;
        }

        public List<WinningPot> PrizeCalc()
        {
            float money = 5000;
            const int total_prizes = 50;
            float last_prize = 1;
            float[] prizes = new float[total_prizes + 1];

            var result = new List<WinningPot>();

            var first_prize=2*money/total_prizes-last_prize; //last member of the progresion
            var ratio=(first_prize-last_prize)/(total_prizes-1);
            prizes[total_prizes]=last_prize;
            for(int i=total_prizes-1;i>=1;i--){
               prizes[i]=prizes[i+1]+ratio;
               money-=prizes[i];
            }
            for(int i=1;i<=total_prizes;i++){
                result.Add(new WinningPot()
                {
                    PlaceID = i,
                    Prize = (decimal)prizes[i]
                });
            }

            return result;
        }
    }
}
