# Make Me Beauty - Test Refactoring Exercise

This exercise contains a Tennis Score Engine with working functionality but
**poorly written tests**. Your mission is to refactor the tests to make them
maintainable and readable.

The tests are organized by **difficulty step** (🟢 Easy → 🟡 Medium → 🔴 Hard).

## The Tennis Score Engine

The `TennisScoreEngine` class implements standard tennis scoring rules:

- Scores progress: Love → 15 → 30 → 40 → Win
- When both players reach 40, it's "Deuce"
- After Deuce, a player must win by 2 points (Advantage → Win)
- If the player with Advantage loses the next point, it returns to Deuce

## What's Wrong with the Current Tests?

The tests in `TennisScoreEngineTests.cs` have multiple problems that make them
difficult to maintain:

- **Poor Test Names**, When a test fails, you can't quickly understand what
  broke

- **Poor Variable Naming**, Variables like `e` and `s` are cryptic

- **No AAA Pattern**, Current tests mix these phases together, making them
  hard to read

- **Multiple Assertions per Test**, When a test fails, you can't tell which
  specific scenario broke

## Recommended Approach: Start Easy! 🟢

The tests are organized by difficulty in `TennisScoreEngineTests.cs`:

### 🟢 Step 1: Easy (Start Here!)

- **Test1** - Needs better naming and AAA structure
- **Test2** - Straightforward win condition test

### 🟡 Step 2: Medium

- **Test3** - Multiple assertions, needs splitting
- **Test4** - Four scenarios in one test
- **Test5** - Uses a loop, tests Deuce scenarios

### 🔴 Step 3: Hard (Save for Last!)

- **Test6** - Complex Deuce/Advantage transitions
- **Test7** - Tests 3 different concerns!
- **Test8** - Hardest! Tests entire game flow with 6 assertions

## Your Task

Refactor the tests in `TennisScoreEngineTests.cs` following these principles:

Good luck, and remember: **Tests are documentation!** They should clearly
communicate what the system does.
