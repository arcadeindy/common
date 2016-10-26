using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinPokerCommonLib
{
    [Serializable]
    public class ProfileModel
    {
        public UserModel User { get; set; }
        public List<TableModel> PlayingOnTables { get; set; }

        public ProfileModel()
        {
            PlayingOnTables = new List<TableModel>();
        }
    }
}
