using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsV1
{

    class Program
    {
        static void Main(string[] args)
        {

            Team[] Teams = new Team[StaticProperties.MaxTeams];
            TeamScore[] TeamScores = new TeamScore[StaticProperties.MaxTeams];
            PlayerScore[] PlayerScores = new PlayerScore[StaticProperties.MaxTeams];
            Match Matchs = new Match();
            float Mom=0;
            float HighsScore=0;
            
            Console.WriteLine("*\t*\t*welcome to premier Leage*\t*\t*");
            Console.WriteLine("\n\nInsert team names");
           
            
            //Taking team names
            for (int TeamCount = 0; TeamCount < Teams.Length; TeamCount++)
            {
                Teams[TeamCount] = new Team();
                Console.WriteLine("Insert name of team {0}: ", Teams[TeamCount].TeamName);
                Teams[TeamCount].TeamName = Console.ReadLine();
            }

            //inserting player data in each team
            for (int PlayerCount = 0; PlayerCount < Teams.Length; PlayerCount++)
            {
                
                Console.WriteLine("Insert 11 players data for team : " + Teams[PlayerCount].TeamName);
                for (int count = 0; count < Teams[PlayerCount].Players.Length; count++)
                {
                    Teams[PlayerCount].Players[count] = new Player();
                    Console.WriteLine("Insert player name  "+(count+1)+" :");
                    Teams[PlayerCount].Players[count].PlayerName = Console.ReadLine();

                    Console.WriteLine("Insert Jourcey number for : "+Teams[PlayerCount].Players[count].PlayerName);
                    //validation not done
                    Teams[PlayerCount].Players[count].JourceyNumber = Int32.Parse(Console.ReadLine());
                    //strike rate
                    //Console.WriteLine("Insert strike rate of the player: " + teammainobj[i].teamplayerobj[count]._playerName);
                    //teammainobj[i].teamplayerobj[count]._strikeRate = float.Parse(Console.ReadLine());
                }
            }

            //show players
            Console.Clear();
            //Console.WriteLine("\n players Data for team: "+Teams[0].TeamName);
            for (int TeamCount = 0; TeamCount < Teams.Length; TeamCount++)
            {
                Console.WriteLine("\n player data for team " + Teams[TeamCount].TeamName);
                Console.WriteLine("\n player name\tjourcey number");
                for (int PlayerCount = 0; PlayerCount < Teams[TeamCount].Players.Length; PlayerCount++)
                {
                    Console.WriteLine(Teams[TeamCount].Players[PlayerCount].PlayerName+"\t\t"+ Teams[TeamCount].Players[PlayerCount].JourceyNumber );
                }
               
            }
      
            //match start
            
            Console.WriteLine("\t\t\tWelcome to premier leage\t\t\n\n Match is started between: \n\t\t\t"+Teams[0].TeamName+"Vs"+Teams[1].TeamName);
            
            Console.WriteLine(Teams[0].TeamName+"Won the Toss and Elected to bat first: ");
            float []Total= new float[2];
           // int MaxBalls = 120;
            int TotalBalls = 0;
            
            for (int TeamCount = 0; TeamCount < Teams.Length; TeamCount++)
            {
                PlayerScores[TeamCount] = new PlayerScore();
                for (int PlayerCount = 0; PlayerCount < PlayerScores[TeamCount].RunsScored.Length; PlayerCount++)
                {
                    TeamScores[TeamCount] = new TeamScore();
                    Console.WriteLine("Enter Run scored by " + Teams[TeamCount].Players[PlayerCount].PlayerName + ": ");
                    PlayerScores[TeamCount].RunsScored[PlayerCount] = Int32.Parse(Console.ReadLine());
                      Console.WriteLine("Balls played: ");

                    PlayerScores[TeamCount].BallsPlayed[TeamCount] = Int32.Parse(Console.ReadLine());
                    //totalballs = totalballs + tempballs;
                    //if (totalballs < maxballs)
                    //{
                    //    playerscore[i]._BallsPlayed[i] = tempballs;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Enter valid data : Remaining balls : " + (maxballs - totalballs));
                    //    goto balls;
                    //}
                    Teams[TeamCount].Players[PlayerCount].StrikeRate = (PlayerScores[TeamCount].RunsScored[PlayerCount] / PlayerScores[TeamCount].BallsPlayed[TeamCount]) * 100;
                    Total[TeamCount] = Total[TeamCount] + PlayerScores[TeamCount].RunsScored[PlayerCount];
                    if (PlayerCount == PlayerScores[TeamCount].RunsScored.Length-1)
                    {
                        Console.WriteLine("\t\t\t******Score Card******");
                        Console.WriteLine("\n\nplayer name\tscore\tstrike rate");
                        for (int PlayerCount2 = 0; PlayerCount2 < PlayerScores[TeamCount].RunsScored.Length; PlayerCount2++)
                        {
                            Console.WriteLine(Teams[TeamCount].Players[PlayerCount2].PlayerName + "\t\t" + PlayerScores[TeamCount].RunsScored[PlayerCount2] + "\t\t" + Teams[TeamCount].Players[PlayerCount2].StrikeRate);
                        }
                    }
                   
                }
                TeamScores[TeamCount].TotalScore = Total[TeamCount];
                Console.WriteLine("\n\n "+(TeamCount+1) +" inning is over " + Teams[TeamCount].TeamName + " scored " + TeamScores[TeamCount].TotalScore);
            }
            //Console.WriteLine("\t\t\t******Score Card******");
            //for (int TeamCount = 0; TeamCount < Teams.Length; TeamCount++)
            //{
            //    Console.WriteLine("\n Team " + Teams[TeamCount].TeamName);

            //    Console.WriteLine("\nplayer name\tscore\tstrike rate");

            //    for (int PlayerCount = 0; PlayerCount < Teams[TeamCount].Players.Length; PlayerCount++)
            //    {
                   
            //        Console.WriteLine(Teams[TeamCount].Players[PlayerCount].PlayerName  + "\t\t" + PlayerScores[TeamCount].RunsScored[PlayerCount] +"\t\t" +Teams[TeamCount].Players[PlayerCount].StrikeRate);
            //    }
            //    if (TeamCount == 0)
            //    {
            //        Console.WriteLine("\n\n 1st inning is over " + Teams[0].TeamName + " scored " + TeamScores[0].TotalScore);
            //    }
            //    else
            //    {
            //        Console.WriteLine("\n\n 2nd inning is over " + Teams[1].TeamName + " scored " + TeamScores[1].TotalScore);
            //    }

            //}
       
             Console.WriteLine("\t\t\t\t*****Results******");
           
                    if (TeamScores[0].TotalScore > TeamScores[1].TotalScore)
                    {
                        Console.WriteLine("\t\t"+Teams[0].TeamName + " won by " + (TeamScores[0].TotalScore - TeamScores[1].TotalScore) + " Runs");
                        TeamScores[0].IsWin = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("\t\t"+Teams[1].TeamName + " won by " + (TeamScores[1].TotalScore - TeamScores[0].TotalScore) + " Runs");
                         TeamScores[1].IsWin = true;
                         
                    }   
            //man of the match 
            for (int TeamCount = 0; TeamCount < Teams.Length; TeamCount++)
            {
                if (TeamScores[TeamCount].IsWin == true)
                {

                    for (int PlayerCount = 0; PlayerCount < PlayerScores.Length; PlayerCount++)
                    {
                        if (PlayerCount == 0)
                        {
                            Matchs.ManOfTheMatch = Teams[TeamCount].Players[PlayerCount].PlayerName;
                            Mom = PlayerScores[TeamCount].RunsScored[PlayerCount];
                        }
                        else
                        {
                            if (PlayerScores[TeamCount].RunsScored[PlayerCount + 1] > PlayerScores[TeamCount].RunsScored[PlayerCount])
                            {
                                Matchs.ManOfTheMatch = Teams[TeamCount].Players[PlayerCount + 1].PlayerName;
                                Mom = PlayerScores[TeamCount].RunsScored[PlayerCount+1];

                            }
                            else
                            {
                                Matchs.ManOfTheMatch = Teams[TeamCount].Players[PlayerCount].PlayerName;
                                Mom = PlayerScores[TeamCount].RunsScored[PlayerCount];
                            }
                        }
                    }
                }
                else
                {
                    for (int PlayerCount = 0; PlayerCount < PlayerScores.Length; PlayerCount++)
                    {
                        if (PlayerCount == 0)
                        {
                            Matchs.HighScorer = Teams[TeamCount].Players[PlayerCount].PlayerName;
                            HighsScore = PlayerScores[TeamCount].RunsScored[PlayerCount];
                        }
                        else
                        {
                            if (PlayerScores[TeamCount].RunsScored[PlayerCount + 1] > PlayerScores[TeamCount].RunsScored[PlayerCount])
                            {
                                Matchs.HighScorer = Teams[TeamCount].Players[PlayerCount + 1].PlayerName;
                                HighsScore = PlayerScores[TeamCount].RunsScored[PlayerCount+1];
                            }
                            else
                            {
                                Matchs.HighScorer = Teams[TeamCount].Players[PlayerCount].PlayerName;
                                HighsScore = PlayerScores[TeamCount].RunsScored[PlayerCount];
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Man Of the Match is : "+ Matchs.ManOfTheMatch);
            //Console.WriteLine("higher scorer of losing team :" + Match.HighScorer);
            
            if(Mom > HighsScore)
            {
                Console.WriteLine("Man of the series is " + Matchs.ManOfTheMatch);
            }
            else
            {
                Console.WriteLine("Man of the series is " + Matchs.HighScorer);
            }
            Console.ReadKey();
        }
    }
}
