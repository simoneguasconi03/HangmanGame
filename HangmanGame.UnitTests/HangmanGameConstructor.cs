using HangmanGame.Core;

namespace HangmanGame.UnitTests;

public class HangmanGameConstructor
{
    private const string testSecretWord = "TEST";
    private HangmanGameEngine _game = new(testSecretWord);

    [Fact]
    public void HasMaskedWordOfAllUnderscores()
    {
        Assert.Equal("____", _game.CurrentMaskedWord);
    }
}
