namespace Teht3_Cards
{
    class PlayingCard
    {
        public string Name { get; }
        public int Value { get; }

        public PlayingCard(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name + " (" + Value + ")";
        }
    }
}
