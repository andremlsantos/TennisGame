namespace Tennis
{
    public class Player
    {
        public string Name { private set; get; }
        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void IncreaseScore()
        {
            Score += 1;
        }
    }
}