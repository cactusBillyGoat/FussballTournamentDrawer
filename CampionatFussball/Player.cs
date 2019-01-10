namespace CampionatFussball
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player
    {
        public string mPreferredPosition;
        public string mNickName;

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return mNickName;
        }
    }
}