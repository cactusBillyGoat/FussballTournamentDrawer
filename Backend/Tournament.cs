using System;
using System.Collections.Generic;
using System.Linq;
using CampionatFussball;

namespace Backend
{
    /// <summary>
    /// Tournament class
    /// </summary>
    public class Tournament
    {
        #region Fields

        private readonly List<Team> mTeams = new List<Team>();
        private readonly List<Player> mDefendingPlayers = new List<Player>();
        private readonly List<Player> mAttackingPlayers = new List<Player>();
        private readonly List<Player> mPolyvalentPlayers = new List<Player>();

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance has been drawn.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has been drawn; otherwise, <c>false</c>.
        /// </value>
        public bool HasBeenDrawn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [teams have been drawn].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [teams have been drawn]; otherwise, <c>false</c>.
        /// </value>
        public bool TeamsHaveBeenDrawn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the players difference
        /// </summary>
        private int PlayersDifference => mAttackingPlayers.Count - mDefendingPlayers.Count;

        /// <summary>
        /// Gets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public List<Player> Players { get; } = new List<Player>();

        /// <summary>
        /// Gets a value indicating whether [any players].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [any players]; otherwise, <c>false</c>.
        /// </value>
        public bool AnyPlayers => Players.Any();

        /// <summary>
        /// Gets a value indicating whether [any teams].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [any teams]; otherwise, <c>false</c>.
        /// </value>
        public bool AnyTeams => mTeams.Any();

        /// <summary>
        /// Gets the tree.
        /// </summary>
        /// <value>
        /// The tree.
        /// </value>
        public List<string> Tree
        {
            get;
            private set;
        }

        #endregion Properties

        /// <summary>
        /// Adds the player.
        /// </summary>
        /// <param name="Player">The player.</param>
        public void AddPlayer(Player Player)
        {
            Players.Add(Player);
        }

        /// <summary>
        /// Edits the player.
        /// </summary>
        /// <param name="Player">The player.</param>
        /// <param name="NewNickName">New name of the nick.</param>
        /// <param name="NewPreferredPosition">The new preferred position.</param>
        public void EditPlayer(Player Player, string NewNickName, Enums.PlayerStyle NewPreferredPosition)
        {
            foreach (var player in Players)
            {
                if (!player.Equals(Player)) continue;

                player.NickName = NewNickName;
                player.PreferredPosition = NewPreferredPosition;

                return;
            }
        }

        /// <summary>
        /// Deletes the player.
        /// </summary>
        /// <param name="Player">The player.</param>
        public void DeletePlayer(Player Player)
        {
            foreach (var player in Players)
            {
                if (!player.Equals(Player)) continue;

                Players.Remove(player);

                return;
            }
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
                    case Enums.PlayerStyle.Attack:
                        mAttackingPlayers.Add(player);
                        break;
                    case Enums.PlayerStyle.Defend:
                        mDefendingPlayers.Add(player);
                        break;
                    case Enums.PlayerStyle.Polyvalent:
                        mPolyvalentPlayers.Add(player);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"{player.PreferredPosition} is not a valid preferred position!");
                }
            }
        }

        /// <summary>
        /// Draws the teams.
        /// </summary>
        public void DrawTeams()
        {
            PopulatePlayerPositionsLists();
            ShufflePlayers();

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
                        mAttackingPlayers.Add(mAttackingPlayers[new Random().Next(0, mAttackingPlayers.Count - 1)]);
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

                TeamsHaveBeenDrawn = true;
            }
            catch
            {
                TeamsHaveBeenDrawn = false;
            }
        }

        /// <summary>
        /// Draws the tournament.
        /// </summary>
        public void DrawTournament()
        {
            try
            {
                mTeams.Shuffle();
                Tree = new List<string>();
                for (var i = 0; i < mTeams.Count - 1; i += 2)
                {
                    Tree.Add($"{mTeams[i]} vs {mTeams[i + 1]}\n");
                }

                HasBeenDrawn = true;
            }
            catch
            {
                HasBeenDrawn = false;
            }
            
        }
    }
}