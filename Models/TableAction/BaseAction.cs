using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPokerCommonLib.Models.Action
{
    [Serializable]
    public class BaseAction : IAction 
    {
        public Enums.Stage Stage { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
