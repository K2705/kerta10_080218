namespace Teht5_Hockey
{
    enum Handed : byte { Right, Left }

    /// <summary>
    /// A hockey player
    /// </summary>
    class HockeyPlayer
    {
        /// <summary>
        /// The Player's first name
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// The Player's last name
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// the Player's number
        /// </summary>
        public int PlayerNumber { get; }
        /// <summary>
        /// whether the Player is left or right handed
        /// </summary>
        public Handed Handed { get; }

        public HockeyPlayer(string FirstName, string LastName, int PlayerNumber, Handed Handed)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PlayerNumber = PlayerNumber;
            this.Handed = Handed;
        }

        /// <summary>
        /// return the Player's name, formatted as Firstname Lastname
        /// </summary>
        /// <returns>Player's first and last name as string</returns>
        public override string ToString()
        {
            return PlayerNumber + " " + FirstName + " " + LastName + (Handed == Handed.Left ? " L" : " R") ;
        }
    }
}
