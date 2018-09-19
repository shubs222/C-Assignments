using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsV1
{
    
    public class Team
    {
        public string TeamName;
        public Player[] Players = new Player[StaticProperties.MaxPlayers];
    }

}
