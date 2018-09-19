using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.SportsAssembly
{
    public  class Match
    {
        //public string ManOfTheMatch;
        //public string HighScorer;
        public TeamScore TeamsScore1=new TeamScore(); 
        public  TeamScore TeamsScore2=new TeamScore();
        //PlayerScore[] playerScores = new PlayerScore[StaticProperties.MaxPlayers];
        public void GetResult()
        {
            if (TeamsScore1.TotalScore > TeamsScore2.TotalScore)
            {
                TeamsScore1.IsWin = true;
                Console.WriteLine("Team " + TeamsScore1.TeamName + " Won by " + (TeamsScore1.TotalScore - TeamsScore2.TotalScore));
            }
            else
            {
                TeamsScore2.IsWin = true;
                Console.WriteLine("Team " + TeamsScore2.TeamName + " Won by " + (TeamsScore2.TotalScore - TeamsScore1.TotalScore));
            }
        }
        public void GetManOfTheMatch()
        {
            if (TeamsScore1.IsWin == true)
            {
                Console.WriteLine("Man of Match :" + TeamsScore1.HighScotrer.Players.PlayerName);
            }
            else
            {
                Console.WriteLine("Man of Match :" + TeamsScore2.HighScotrer.Players.PlayerName);
            }
        }
        public void GetHighScorer()
        {
            if (TeamsScore1.HighScotrer.RunsScored > TeamsScore2.HighScotrer.RunsScored)
            {
                Console.WriteLine("Man of the Series is : " + TeamsScore1.HighScotrer.Players.PlayerName);
            }
            else
            {
                Console.WriteLine("Man of the Series is : " + TeamsScore2.HighScotrer.Players.PlayerName);
            }
        }

    }

}

