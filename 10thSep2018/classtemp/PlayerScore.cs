using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsV1
{
    public class PlayerScore
    {
        public float[] RunsScored = new float[StaticProperties.MaxPlayers];
        public float[] BallsPlayed = new float[StaticProperties.MaxPlayers];
        public Player Players;

    }
}
