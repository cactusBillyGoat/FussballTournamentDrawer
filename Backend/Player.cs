using CampionatFussball;

namespace Backend
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the preferred position.
        /// </summary>
        /// <value>
        /// The preferred position.
        /// </value>
        public Enums.PlayerStyle PreferredPosition
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the nick.
        /// </summary>
        /// <value>
        /// The name of the nick.
        /// </value>
        public string NickName
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="Position">The position.</param>
        /// <param name="Name">The name.</param>
        public Player(string Name, Enums.PlayerStyle Position)
        {
            NickName = Name;
            PreferredPosition = Position;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{NickName}  ->  {PreferredPosition}";
        }

        /// <summary>
        /// Converts to short string.
        /// </summary>
        /// <returns></returns>
        public string ToShortString()
        {
            return NickName;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="Obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
#pragma warning disable 659
        public override bool Equals(object Obj) => ((Player) Obj)?.NickName == NickName;
#pragma warning restore 659
    }
}