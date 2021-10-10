namespace TennisGame
{
    static class Program
    {
        static void Main(string[] args)
        {
            var tennis = new TennisGame1(new Player("1"), new Player("2"));
            var score = tennis.GetScore();
        }
    }
}
