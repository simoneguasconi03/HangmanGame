namespace HangmanGame.Core;

public class HangmanGameOriginator : HangmanGame
{
    public HangmanGameMemento CreateSetPoint()
    {
        var guesses = PreviousGuesses.ToArray();
        return new HangmanGameMemento() { Guesses = guesses };
    }

    public void ResumeFrom(HangmanGameMemento hangmanMemento)
    {
        var guesses = hangmanMemento.Guesses;
        PreviousGuesses.Clear();
        PreviousGuesses.AddRange(guesses);
    }
}
