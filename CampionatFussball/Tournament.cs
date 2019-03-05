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

        public List<Team> Teams = new List<Team>();
        public List<Player> Players = new List<Player>();
        private List<Player> mDefendingPlayers = new List<Player>();
        private List<Player> mAttackingPlayers = new List<Player>();
        private List<Player> mPolyvalentPlayers = new List<Player>();

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance has been drawed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has been drawed; otherwise, <c>false</c>.
        /// </value>
        public bool HasBeenDrawed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [teams have been drawed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [teams have been drawed]; otherwise, <c>false</c>.
        /// </value>
        public bool TeamsHaveBeenDrawed
        {
            get;
            set;
        }

        #endregion Properties

        /// <summary>
        /// Starts the tournament.
        /// </summary>
        public void PopulateAndSufflePlayers()
        {
            PopulatePlayerList();
            PopulatePlayerPositionsLists();
            ShufflePlayers();
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
            foreach (var player in Players)
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

            Players = file_lines.Select(Line => Line.Split(' '))
                .Select(Values => new Player {NickName = Values[0], PreferredPosition = Values[1]})
                .ToList();
        }

        /// <summary>
        /// Draws the teams.
        /// </summary>
        public void DrawTeams()
        {
            try
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
                    Teams.Add(new Team
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
                        mAttackingPlayers.Add(mAttackingPlayers[new Random().Next(0, mAttackingPlayers.Count - 1)]);
                    }

                    for (var i = mAttackingPlayers.Count - PlayersDifference; i < mAttackingPlayers.Count - 1; i += 2)
                    {
                        Teams.Add(new Team
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
                        Teams.Add(new Team
                        {
                            mFirstPlayer = mDefendingPlayers[i],
                            mSecondPlayer = mDefendingPlayers[i + 1],
                        });
                    }
                }

                if (Teams.Count % 2 != 0)
                {
                    Teams.Add(new Team
                    {
                        mFirstPlayer = mDefendingPlayers[new Random().Next(0, mDefendingPlayers.Count - 1)],
                        mSecondPlayer = mAttackingPlayers[new Random().Next(0, mAttackingPlayers.Count - 1)],
                    });
                }

                TeamsHaveBeenDrawed = true;
            }
            catch
            {
                TeamsHaveBeenDrawed = false;
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
        public void DrawTournament()
        {
            try
            {
                Teams.Shuffle();

                var output_file = File.Exists(Utilities.OutputFilePath)
                    ? $"{Utilities.OutputFilePath.Replace(".txt", "")}{DateTime.Now.ToShortDateString()}.txt"
                    : Utilities.OutputFilePath;

                var output_file_lines = new List<string>();

                for (var i = 0; i < Teams.Count - 1; i += 2)
                {
                    output_file_lines.Add($"{Teams[i]} vs {Teams[i + 1]}\n");
                }

                File.WriteAllLines(output_file, output_file_lines);

                HasBeenDrawed = true;
            }
            catch
            {
                HasBeenDrawed = false;
            }
            
        }
    }
}