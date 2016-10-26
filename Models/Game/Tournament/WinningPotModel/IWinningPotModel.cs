using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Game.Tournament.WinningPotModel
{
    public interface IWinningPotModel
    {
        List<WinningPot> PrizeCalc();
    }
}
