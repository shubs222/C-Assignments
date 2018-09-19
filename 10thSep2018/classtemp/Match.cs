using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsV1
{
     class Match
    {
        public string ManOfTheMatch;
        public string HighScorer;
        public TeamScore[] TeamScore = new TeamScore[StaticProperties.MaxTeams];
        //PlayerScore[] playerScores = new PlayerScore[StaticProperties.MaxPlayers];

        
    }
}
