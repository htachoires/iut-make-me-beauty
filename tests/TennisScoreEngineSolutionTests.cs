namespace MakeMeBeauty.Tests;

public class TennisScoreEngineSolutionTests
{
    #region Solutions for Test1 (30-40 score with poor variable names)

    [Fact]
    public void Test1_Should_Return30Dash40_When_Player1Has30AndPlayer2Has40()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player2Scores();
        engine.Player2Scores();
        engine.Player2Scores();

        // Act
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("30-40", actualScore);
    }

    #endregion

    #region Solutions for Test2 (Player 2 wins after 4 points)

    [Fact]
    public void Test2_Should_ShowPlayer2Wins_When_Player2ScoresFourTimesFromStart()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player2Scores();
        engine.Player2Scores();
        engine.Player2Scores();

        // Act
        engine.Player2Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Player 2 Wins", actualScore);
    }

    #endregion

    #region Solutions for Test3 (Player 1 reaches 40, then wins - 2 assertions)

    [Fact]
    public void Test3_Should_Return40Love_When_Player1ScoresThreeTimesFromStart()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();

        // Act
        engine.Player1Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("40-Love", actualScore);
    }

    [Fact]
    public void Test3_Should_ShowPlayer1Wins_When_Player1ScoresFourthPointAt40Love()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player1Scores();

        // Act
        engine.Player1Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Player 1 Wins", actualScore);
    }

    #endregion

    #region Solutions for Test4 (4 different scenarios: Love-Love, 15-Love, 30-Love, 30-15)

    [Fact]
    public void Test4_Should_ReturnLoveLove_When_InInitialState()
    {
        // Arrange
        var engine = new TennisScoreEngine();

        // Act
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Love-Love", actualScore);
    }

    [Fact]
    public void Test4_Should_Return15Love_When_Player1ScoresOnceFromLove()
    {
        // Arrange
        var engine = new TennisScoreEngine();

        // Act
        engine.Player1Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("15-Love", actualScore);
    }

    [Fact]
    public void Test4_Should_Return30Love_When_Player1ScoresTwiceFromLove()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player1Scores();

        // Act
        engine.Player1Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("30-Love", actualScore);
    }

    [Fact]
    public void Test4_Should_Return30Dash15_When_Player1Has30AndPlayer2Has15()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();

        // Act
        engine.Player2Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("30-15", actualScore);
    }

    #endregion

    #region Solutions for Test5 (Deuce → Advantage Player 2 → Win with loop)

    [Fact]
    public void Test5_Should_ReturnDeuce_When_BothPlayersHave3Points()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        ScorePoints(engine, 3, 3);

        // Act
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Deuce", actualScore);
    }

    [Fact]
    public void Test5_Should_ReturnAdvantagePlayer2_When_Player2ScoresOnceFromDeuce()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        ScorePoints(engine, 3, 3);

        // Act
        engine.Player2Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Advantage Player 2", actualScore);
    }

    [Fact]
    public void Test5_Should_ShowPlayer2Wins_When_Player2ScoresTwiceFromDeuce()
    {
        // Arrange
        var engine = new TennisScoreEngine();
        ScorePoints(engine, 3, 3);
        engine.Player2Scores();

        // Act
        engine.Player2Scores();
        var actualScore = engine.GetScore();

        // Assert
        Assert.Equal("Player 2 Wins", actualScore);
    }

    #endregion

    #region Helper Methods

    private static void ScorePoints(TennisScoreEngine engine, int player1Points, int player2Points)
    {
        for (int i = 0; i < player1Points; i++)
        {
            engine.Player1Scores();
        }

        for (int i = 0; i < player2Points; i++)
        {
            engine.Player2Scores();
        }
    }

    #endregion
}
