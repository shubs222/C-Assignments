using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsV1
{
    public class TeamScore : Team
    {
        public bool IsWin = false;
        public PlayerScore[] PlayersScore = new PlayerScore[StaticProperties.MaxPlayers];
        public float TotalScore;
    }
}
