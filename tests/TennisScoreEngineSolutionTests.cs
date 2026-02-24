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
}
