using Tennis;

namespace UI
{
    static class Program
    {
        static void Main(string[] args)
        {
            const string player1Name = "Roger Federer";
            const string player2Name = "Rafael Nadal";

            var player1 = new Player(player1Name);
            var player2 = new Player(player2Name);
            var game = new TennisGame1(player1, player2);

            game.WonPoint(player1Name);
            game.WonPoint(player1Name);


            var score = game.GetScore();
        }
    }
}
