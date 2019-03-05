namespace Backend
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player
    {
        public string PreferredPosition;
        public string NickName;

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return NickName;
        }
    }
}