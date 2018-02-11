namespace Teht5_Hockey
{
    class Program
    {
        static void Main(string[] args)
        {
            HockeyTeam kalpa = new HockeyTeam("Kalpa", "Kuopio", "players.txt");
            kalpa.Print();

            kalpa.Save("players.txt");
        }
    }
}
