using System;

namespace Sports.SportsAssembly
{
    public  class Team
    {
        public string TeamName;
        protected internal Player[] Players = new Player[StaticProperties.MaxPlayers];
        public void SetTeam()
        {
            Console.WriteLine("Insert name of team : ");
            TeamName = Console.ReadLine();
        }
        public void SetPlayerData()
        {
            Console.WriteLine("Insert 11 players data for team : " + this.TeamName);
            for (int count = 0; count < StaticProperties.MaxPlayers; count++)
            {
                Players[count] = new Player();
                Console.WriteLine("Insert player name  " + (count + 1) + " :");
                Players[count].PlayerName = Console.ReadLine();

                Console.WriteLine("Insert Jourcey number for : " + Players[count].PlayerName);
                //validation not done
                Players[count].JourceyNumber = Int32.Parse(Console.ReadLine());
                //strike rate
                //Console.WriteLine("Insert strike rate of the player: " + teammainobj[i].teamplayerobj[count]._playerName);
                //teammainobj[i].teamplayerobj[count]._strikeRate = float.Parse(Console.ReadLine());
            }
        }
        public void GetPlayerData()
        {
            Console.WriteLine("\n players Data for team: " + this.TeamName);
            Console.WriteLine("\n player name\tjourcey number");
            for (int PlayerCount = 0; PlayerCount < StaticProperties.MaxPlayers; PlayerCount++)
            {
                Console.WriteLine(Players[PlayerCount].PlayerName + "\t\t" + Players[PlayerCount].JourceyNumber);
            }

        }
    }
}
