using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Action
{
    public interface IAction
    {
        Enums.Stage Stage { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
