namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private string _score = string.Empty;

        private readonly Player _player1;
        private readonly Player _player2;

        public TennisGame1(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void WonPoint(string playerName)
        {
            if (IsPlayer1(playerName))
                _player1.IncreaseScore();
            else if (IsPlayer2(playerName))
                _player2.IncreaseScore();
        }

        private bool IsPlayer1(string playerName)
        {
            return playerName == _player1.Name;
        }

        private bool IsPlayer2(string playerName)
        {
            return playerName == _player2.Name;
        }

        public string GetScore()
        {
            if (IsTie(_player1, _player2))
            {
                _score = BuildTieScore();
            }
            else if (IsWinnable(_player1, _player2))
            {
                var scoreDifference = _player1.Score - _player2.Score;
                _score = BuildWinnableScore(scoreDifference);
            }
            else
            {
                NextTurn();
            }

            return _score;
        }

        private bool IsTie(Player player1, Player player2)
        {
            return player1.Score == player2.Score;
        }

        private string BuildTieScore()
        {
            return _player1.Score switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                3 => "Forty-All",
                _ => "Deuce"
            };
        }

        private bool IsWinnable(Player player1, Player player2)
        {
            return player1.Score >= 4 || player1.Score >= 4;
        }

        private static string BuildWinnableScore(int playersScoreDifference)
        {
            return playersScoreDifference switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };
        }

        private void NextTurn()
        {
            for (var playerTurn = 1; playerTurn <= 2; playerTurn++)
            {
                var playersScore = 0;
                if (IsPlayer1Turn(playerTurn))
                {
                    playersScore = _player1.Score;
                }
                else
                {
                    _score += "-";
                    playersScore = _player2.Score;
                }

                _score = BuildCurrentScore(playersScore);
            }
        }

        private static bool IsPlayer1Turn(int turn)
        {
            return turn == 1;
        }

        private string BuildCurrentScore(int score)
        {
            switch (score)
            {
                case 0:
                    _score += "Love";
                    break;
                case 1:
                    _score += "Fifteen";
                    break;
                case 2:
                    _score += "Thirty";
                    break;
                case 3:
                    _score += "Forty";
                    break;
            }

            return _score;
        }
    }
}
