using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CampionatFussball
{
    /// <summary>
    /// Tournament class
    /// </summary>
    public class Tournament
    {
        public List<Team> mTeams = new List<Team>();
        public List<Player> mPlayers;

        /// <summary>
        /// Starts the tournament.
        /// </summary>
        public void Start()
        {
            mPlayers = GetPlayers();
            DrawTeams();
            DrawTournament();
        }

        /// <summary>
        /// Gets the players.
        /// </summary>
        /// <returns></returns>
        private List<Player> GetPlayers()
        {
            var file_lines = File.ReadAllLines(Utilities.InputFilePath);

            var players_list = file_lines.Select(Line => Line.Split(' '))
                .Select(Values => new Player {mNickName = Values[0], mPreferredPosition = Values[1]})
                .ToList();

            return players_list;
        }

        /// <summary>
        /// Draws the teams.
        /// </summary>
        private void DrawTeams()
        {
            var defending_players = new List<Player>();
            var attacking_players = new List<Player>();

            foreach (var player in mPlayers)
            {
                if (player.mPreferredPosition.Equals("Attack"))
                {
                    attacking_players.Add(player);
                }
                else
                {
                    defending_players.Add(player);
                }
            }

            defending_players.Shuffle();
            attacking_players.Shuffle();


            for (var i = 0; i < Math.Min(defending_players.Count, attacking_players.Count); i++)
            {
                mTeams.Add(new Team
                {
                    mFirstPlayer = defending_players[i],
                    mSecondPlayer = attacking_players[i],
                });
            }


            var players_difference = defending_players.Count - attacking_players.Count;

            if (players_difference == 0)
            {
                return;
            }

            if (players_difference < 0)
            {
                players_difference = Math.Abs(players_difference);

                for (var i = attacking_players.Count - players_difference; i < attacking_players.Count - 1; i += 2)
                {
                    mTeams.Add(new Team
                    {
                        mFirstPlayer = attacking_players[i],
                        mSecondPlayer = attacking_players[i + 1],
                    });
                }
            }
            else
            {
                for (var i = defending_players.Count - players_difference; i < defending_players.Count - 1; i += 2)
                {
                    mTeams.Add(new Team
                    {
                        mFirstPlayer = defending_players[i],
                        mSecondPlayer = defending_players[i + 1],
                    });
                }
            }
        }

        /// <summary>
        /// Draws the tournament.
        /// </summary>
        private void DrawTournament()
        {
            mTeams.Shuffle();

            var output_file = File.Exists(Utilities.OutputFilePath)
                ? $"{Utilities.OutputFilePath.Replace(".txt", "")}{DateTime.Now.ToShortDateString()}.txt"
                : Utilities.OutputFilePath;

            //File.Create(output_file);
            
            var output_file_lines = new List<string>();

            for (var i = 0; i < mTeams.Count-1; i+=2)
            {
                output_file_lines.Add($"{mTeams[i]} vs {mTeams[i+1]}\n");
            }

            File.WriteAllLines(output_file, output_file_lines);
        }
    }
}