namespace MakeMeBeauty.Tests;

public class TennisScoreEngineTests
{
    // ═══════════════════════════════════════════════════════════════════════════
    // 🟢 STEP 1: EASY
    // ═══════════════════════════════════════════════════════════════════════════

    // PROBLEMS: Bad name, poor variable naming, no AAA structure
    // HINT: This tests a basic score. What score? Be specific in the name!
    [Fact]
    public void Test1()
    {
        var e = new TennisScoreEngine();
        e.Player1Scores();
        e.Player1Scores();
        e.Player2Scores();
        e.Player2Scores();
        e.Player2Scores();
        var s = e.GetScore();
        Assert.Equal("30-40", s);
    }

    // PROBLEMS: Bad name, no AAA structure
    // HINT: What happens when Player 2 scores 4 times from the start?
    [Fact]
    public void Test2()
    {
        var engine = new TennisScoreEngine();
        engine.Player2Scores();
        engine.Player2Scores();
        engine.Player2Scores();
        engine.Player2Scores();
        Assert.Equal("Player 2 Wins", engine.GetScore());
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // 🟡 STEP 2: MEDIUM
    // ═══════════════════════════════════════════════════════════════════════════

    // PROBLEMS: Bad name, multiple assertions (2 different things!), no AAA
    // HINT: This tests winning AND scoring. Should be split into 2+ tests!
    [Fact]
    public void Test3()
    {
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player1Scores();
        Assert.Equal("40-Love", engine.GetScore());
        engine.Player1Scores();
        Assert.Equal("Player 1 Wins", engine.GetScore());
    }

    // PROBLEMS: Bad name, 4 different assertions (tests 4 scenarios!), no AAA
    // HINT: This should be split into at least 4 separate tests!
    [Fact]
    public void Test4()
    {
        var engine = new TennisScoreEngine();
        Assert.Equal("Love-Love", engine.GetScore());
        engine.Player1Scores();
        Assert.Equal("15-Love", engine.GetScore());
        engine.Player1Scores();
        Assert.Equal("30-Love", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("30-15", engine.GetScore());
    }

    // PROBLEMS: Bad name, uses a loop (harder to read), multiple assertions, no AAA
    // HINT: The loop makes it less obvious what's happening. This tests Deuce → Advantage → Win
    [Fact]
    public void Test5()
    {
        var engine = new TennisScoreEngine();
        for (int i = 0; i < 3; i++)
        {
            engine.Player1Scores();
            engine.Player2Scores();
        }

        Assert.Equal("Deuce", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("Advantage Player 2", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("Player 2 Wins", engine.GetScore());
    }

    // ═══════════════════════════════════════════════════════════════════════════
    // 🔴 STEP 3: HARD
    // ═══════════════════════════════════════════════════════════════════════════

    // PROBLEMS: Bad name, tests Deuce scenario (complex rules), multiple assertions, no AAA
    // HINT: This tests Deuce → Advantage → Back to Deuce. Each transition should be its own test!
    [Fact]
    public void Test6()
    {
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player2Scores();
        engine.Player2Scores();
        engine.Player2Scores();
        Assert.Equal("Deuce", engine.GetScore());
        engine.Player1Scores();
        Assert.Equal("Advantage Player 1", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("Deuce", engine.GetScore());
    }

    // PROBLEMS: Bad name, tests 3 different concerns (Win + Reset + Score), multiple assertions
    // HINT: This is actually testing 3 completely different things! Split into separate tests!
    //       1. Player winning, 2. Reset functionality, 3. Scoring after reset
    [Fact]
    public void Test7()
    {
        var engine = new TennisScoreEngine();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player1Scores();
        engine.Player1Scores();
        Assert.Equal("Player 1 Wins", engine.GetScore());
        engine.Reset();
        Assert.Equal("Love-Love", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("Love-15", engine.GetScore());
    }

    // PROBLEMS: Bad name, tests ENTIRE game flow, 6 assertions!, no AAA, even has a comment saying it's bad!
    // HINT: This is testing an entire tennis game from start to finish. Each phase should be its own test!
    //       Phases: Initial score → Player 1 leads → Player 2 catches up → Player 1 at 40 → Deuce → Win
    [Fact]
    public void Test8()
    {
        var engine = new TennisScoreEngine();
        // Testing multiple scenarios in one test - bad practice!
        engine.Player1Scores();
        Assert.Equal("15-Love", engine.GetScore());
        engine.Player2Scores();
        engine.Player2Scores();
        Assert.Equal("15-30", engine.GetScore());
        engine.Player1Scores();
        engine.Player1Scores();
        Assert.Equal("40-30", engine.GetScore());
        engine.Player2Scores();
        Assert.Equal("Deuce", engine.GetScore());
        engine.Player1Scores();
        engine.Player1Scores();
        Assert.Equal("Player 1 Wins", engine.GetScore());
    }
}