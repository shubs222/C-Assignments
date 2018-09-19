using System;
using System.Collections.Generic;
using System.Text;

namespace Sports.SportsAssembly
{
    public class TeamScore : Team
    {
        protected internal bool IsWin = false;
        private PlayerScore[] PlayersScore = new PlayerScore[StaticProperties.MaxPlayers];
        protected internal float TotalScore;
        public PlayerScore HighScotrer = new PlayerScore();

        public void MatchStart(Team TeamP)
        {

            float Total = 0;
            // int MaxBalls = 120;
            float TotalBalls = 0;

            TeamName = TeamP.TeamName;
            for (int PlayerCount = 0; PlayerCount < StaticProperties.MaxPlayers; PlayerCount++)
            {

                PlayersScore[PlayerCount] = new PlayerScore();
                PlayersScore[PlayerCount].Players = new Player();

                PlayersScore[PlayerCount].Players = TeamP.Players[PlayerCount];
                if (TotalBalls < StaticProperties.MaxBalls)
                {
                check: Console.WriteLine("Enter Run scored by " + TeamP.Players[PlayerCount].PlayerName + ": ");
                    PlayersScore[PlayerCount].RunsScored = float.Parse(Console.ReadLine());
                    Console.WriteLine("Balls played: ");
                    float temp = float.Parse(Console.ReadLine());
                    if (temp <= (StaticProperties.MaxBalls - TotalBalls))
                    {
                        PlayersScore[PlayerCount].BallsPlayed = temp;
                        TotalBalls = TotalBalls + PlayersScore[PlayerCount].BallsPlayed;
                        Console.WriteLine("Remaining Balls: " + (StaticProperties.MaxBalls - TotalBalls));
                        TeamP.Players[PlayerCount].StrikeRate = (PlayersScore[PlayerCount].RunsScored / PlayersScore[PlayerCount].BallsPlayed) * 100;
                        Total = Total + PlayersScore[PlayerCount].RunsScored;
                    }
                    else
                    {
                        Console.WriteLine("balls remaining " + (StaticProperties.MaxBalls - TotalBalls));
                        goto check;
                    }
                }
                else
                {
                    //Console.WriteLine("Enter Run scored by " + TeamP.Players[PlayerCount].PlayerName + ": ");
                    PlayersScore[PlayerCount].RunsScored = 0;
                    //Console.WriteLine("Balls played: ");
                    PlayersScore[PlayerCount].BallsPlayed = 0;
                    TeamP.Players[PlayerCount].StrikeRate = 0;
                }
                if (PlayerCount == StaticProperties.MaxPlayers - 1)
                {
                    Console.WriteLine("\t\t\t******Score Card******");
                    Console.WriteLine("\n\nplayer name\tscore\t\tstrike rate");
                    for (int j = 0; j < 1; j++)
                    {
                        for (int PlayerCount2 = -1; PlayerCount2 <= StaticProperties.MaxPlayers; PlayerCount2++)
                        {
                            if (PlayerCount2 == -1 || PlayerCount2 == StaticProperties.MaxPlayers)
                            {
                                for (int i = 0; i < 60; i++)
                                {
                                    Console.Write("=");
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("|" + (TeamP.Players[PlayerCount2].PlayerName + "").PadRight(19) + (PlayersScore[PlayerCount2].RunsScored + "").PadRight(20) + (TeamP.Players[PlayerCount2].StrikeRate + "").PadRight(20) + "|");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                if (PlayerCount == 0)
                {
                    HighScotrer = PlayersScore[PlayerCount];
                }
                else
                {
                    if (PlayersScore[PlayerCount].RunsScored > HighScotrer.RunsScored)
                    {
                        HighScotrer = PlayersScore[PlayerCount];
                    }
                }
            }
            TotalScore = Total;
            Console.WriteLine("Run Scored by the team " + TeamP.TeamName + " is: " + TotalScore);
            Console.WriteLine("Highest scorer is : " + HighScotrer.Players.PlayerName);
        }

    }

}
