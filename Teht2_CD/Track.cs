namespace Teht2_CD
{
    /// <summary>
    /// Data structure for a music track
    /// Holds track name and duration in seconds
    /// </summary>
    class Track
    {
        public string Name { get; private set; }
        public int Duration { get; private set; }

        public Track(string name, int duration)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public string DurationMinutes()
        {
            return (Duration / 60).ToString() + ":" + (Duration % 60).ToString("D2");
        }

        public override string ToString()
        {
            return Name + " - " + DurationMinutes();
        }
    }

}