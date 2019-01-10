namespace CampionatFussball
{
    /// <summary>
    /// Team class
    /// </summary>
    public class Team
    {
        public Player mFirstPlayer;
        public Player mSecondPlayer;

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"[{mFirstPlayer} & {mSecondPlayer}]";
        }
    }
}