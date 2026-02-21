namespace MakeMeBeauty;

public class TennisScoreEngine
{
    private int _player1Points;
    private int _player2Points;

    public string GetScore()
    {
        var winner = GetWinner();
        if (winner != 0)
            return winner == 1 ? "Player 1 Wins" : "Player 2 Wins";

        if (IsDeuce())
            return "Deuce";

        var adv = GetAdvantagePlayer();
        if (adv != 0)
            return adv == 1 ? "Advantage Player 1" : "Advantage Player 2";

        return $"{MapScoreName(_player1Points)}-{MapScoreName(_player2Points)}";
    }

    public void Player1Scores() => _player1Points++;

    public void Player2Scores() => _player2Points++;

    public void Reset()
    {
        _player1Points = 0;
        _player2Points = 0;
    }

    private static string MapScoreName(int points)
    {
        return points switch
        {
            0 => "Love",
            1 => "15",
            2 => "30",
            3 => "40",
            _ => "40"
        };
    }

    private bool IsDeuce()
    {
        return _player1Points >= 3 && _player2Points >= 3 && _player1Points == _player2Points;
    }

    private int GetAdvantagePlayer()
    {
        if (_player1Points >= 4 || _player2Points >= 4)
        {
            var diff = _player1Points - _player2Points;
            if (diff == 1)
                return 1;
            if (diff == -1)
                return 2;
        }

        return 0;
    }

    private int GetWinner()
    {
        if (_player1Points >= 4 || _player2Points >= 4)
        {
            var diff = _player1Points - _player2Points;
            if (diff >= 2)
                return 1;
            if (diff <= -2)
                return 2;
        }

        return 0;
    }
}