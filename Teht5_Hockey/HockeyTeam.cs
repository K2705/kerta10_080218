using System;
using System.Collections.Generic;
using System.IO;

namespace Teht5_Hockey
{
    /// <summary>
    /// A hockey team, containing Players
    /// </summary>
    class HockeyTeam
    {
        /// <summary>
        /// team name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// team home city
        /// </summary>
        public string City { get; }
        public List<HockeyPlayer> Players { get; }

        public HockeyTeam(string name, string city, string playerFile)
        {
            this.Name = name;
            this.City = city;
            this.Players = new List<HockeyPlayer>();
            GetPlayers(playerFile);
        }

        public HockeyTeam()
        {

        }

        private void GetPlayers(string playerFile)
        {
            try
            {
                using (StreamReader reader = new StreamReader(playerFile))
                {
                    string playerLine;
                    while ((playerLine = reader.ReadLine()) != null)
                    {
                        string[] playerTokens = playerLine.Split(' ');
                        int playerNumber;
                        int.TryParse(playerTokens[0], out playerNumber);
                        Handed handed;
                        if (playerTokens[3] == "L") handed = Handed.Left;
                        else handed = Handed.Right;

                        Players.Add(new HockeyPlayer(playerTokens[1], playerTokens[2], playerNumber, handed));
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Could not open file:");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Get number of Players
        /// </summary>
        /// <returns>The number of Players, as integer</returns>
        public int PlayerCount()
        {
            return Players.Count;
        }

        /// <summary>
        /// Get the player at specific index
        /// </summary>
        /// <param name="i">Player index, starting from 0</param>
        /// <returns>the Player at i</returns>
        public HockeyPlayer GetPlayer(int i)
        {
            if (i >= Players.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return Players[i];
        }

        /// <summary>
        /// Add new player
        /// </summary>
        /// <param name="player">the Player to add</param>
        public void AddPlayer(HockeyPlayer player)
        {
            Players.Add(player);
        }

        /// <summary>
        /// Print object summary to console
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(City);
            for (int i = 0; i < PlayerCount(); i++)
            {
                Console.WriteLine(GetPlayer(i));
            }
        }

        /// <summary>
        /// Save team data into file
        /// </summary>
        /// <param name="filename">file to save to</param>
        /// <returns>true on success, false on failure</returns>
        public bool Save(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (HockeyPlayer player in Players)
                    {
                        writer.WriteLine(player);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            
        }
    }
}
