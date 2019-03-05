using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Backend
{
    /// <summary>
    /// Tournament class
    /// </summary>
    public class Tournament
    {
        #region Fields

        private List<Team> mTeams = new List<Team>();
        private List<Player> mPlayers;
        private List<Player> mDefendingPlayers = new List<Player>();
        private List<Player> mAttackingPlayers = new List<Player>();
        private List<Player> mPolyvalentPlayers = new List<Player>();

        #endregion Fields

        /// <summary>
        /// Starts the tournament.
        /// </summary>
        public void Start()
        {
            PopulatePlayerList();
            PopulatePlayerPositionsLists();
            ShufflePlayers();
            DrawTeams();
            DrawTournament();
        }

        /// <summary>
        /// Shuffles the player lists
        /// </summary>
        private void ShufflePlayers()
        {
            mDefendingPlayers.Shuffle();
            mAttackingPlayers.Shuffle();
            mPolyvalentPlayers.Shuffle();
        }

        /// <summary>
        /// Populates player lists
        /// </summary>
        private void PopulatePlayerPositionsLists()
        {
            foreach (var player in mPlayers)
            {
                switch (player.PreferredPosition)
                {
                    case "Attack":
                        mAttackingPlayers.Add(player);
                        break;
                    case "Defend":
                        mDefendingPlayers.Add(player);
                        break;
                    default:
                        mPolyvalentPlayers.Add(player);
                        break;
                }
            }
        }

        /// <summary>
        /// Populates the player list
        /// </summary>
        /// <returns></returns>
        private void PopulatePlayerList()
        {
            if (!File.Exists(Utilities.InputFilePath))
            {
                MessageBox.Show($"Please first create {Utilities.InputFilePath} file", "Players file not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FileNotFoundException();
            }

            var file_lines = File.ReadAllLines(Utilities.InputFilePath);

            mPlayers = file_lines.Select(Line => Line.Split(' '))
                .Select(Values => new Player {NickName = Values[0], PreferredPosition = Values[1]})
                .ToList();
        }

        /// <summary>
        /// Draws the teams.
        /// </summary>
        private void DrawTeams()
        {
            if (mPolyvalentPlayers.Any())
            {
                if (PlayersDifference < 0 && mPolyvalentPlayers.Any())
                {
                    var i = 0;
                    while (PlayersDifference < 0)
                    {
                        mAttackingPlayers.Add(mPolyvalentPlayers[i]);
                        mPolyvalentPlayers.RemoveAt(i);
                        i++;
                    }
                }
                else
                {
                    var i = 0;
                    while (PlayersDifference > 0 && mPolyvalentPlayers.Any())
                    {
                        mAttackingPlayers.Add(mPolyvalentPlayers[i]);
                        mPolyvalentPlayers.RemoveAt(i);
                        i++;
                    }
                }

                if (mPolyvalentPlayers.Any() && PlayersDifference == 0)
                {
                    var i = 0;
                    while (mPolyvalentPlayers.Any())
                    {
                        if (i % 2 == 0)
                        {
                            mAttackingPlayers.Add(mPolyvalentPlayers[0]);
                        }
                        else
                        {
                            mDefendingPlayers.Add(mPolyvalentPlayers[0]);
                        }

                        mPolyvalentPlayers.RemoveAt(0);
                        i++;
                    }
                }
            }

            for (var i = 0; i < Math.Min(mDefendingPlayers.Count, mAttackingPlayers.Count); i++)
            {
                mTeams.Add(new Team
                {
                    mFirstPlayer = mDefendingPlayers[i],
                    mSecondPlayer = mAttackingPlayers[i],
                });
            }

            if (PlayersDifference == 0)
            {
                return;
            }

            if (PlayersDifference > 0)
            {
                if (PlayersDifference % 2 != 0)
                {
                    mAttackingPlayers.Add(mAttackingPlayers[new Random().Next(0,mAttackingPlayers.Count -1)]);
                }

                for (var i = mAttackingPlayers.Count - PlayersDifference; i < mAttackingPlayers.Count - 1; i += 2)
                {
                    mTeams.Add(new Team
                    {
                        mFirstPlayer = mAttackingPlayers[i],
                        mSecondPlayer = mAttackingPlayers[i + 1],
                    });
                }
            }
            else
            {
                if (PlayersDifference % 2 != 0)
                {
                    mDefendingPlayers.Add(mDefendingPlayers[new Random().Next(0, mDefendingPlayers.Count - 1)]);
                }

                for (var i = mDefendingPlayers.Count + PlayersDifference; i < mDefendingPlayers.Count - 1; i += 2)
                {
                    mTeams.Add(new Team
                    {
                        mFirstPlayer = mDefendingPlayers[i],
                        mSecondPlayer = mDefendingPlayers[i + 1],
                    });
                }
            }

            if (mTeams.Count % 2 != 0)
            {
                mTeams.Add(new Team
                {
                    mFirstPlayer = mDefendingPlayers[new Random().Next(0, mDefendingPlayers.Count - 1)],
                    mSecondPlayer = mAttackingPlayers[new Random().Next(0, mAttackingPlayers.Count - 1)],
                });
            }
        }

        /// <summary>
        /// Gets the players difference
        /// </summary>
        private int PlayersDifference
        {
            get { return mAttackingPlayers.Count - mDefendingPlayers.Count; }
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