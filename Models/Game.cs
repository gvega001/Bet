using System.Dynamic;

namespace Bet.Models
{
    public interface Game
    {
        int GetScore();
        string GetEventName();
        string SetEventName();
        int GetGuess();
        int SetGuess();
        int GetSmallestPossibleGuess();
        int SetSmallestPossibleGuess();
        int GetBiggestPossibleGuess();
        int SetBiggestPossibleGuess();
        BetImpl Bet();
        void Reset();
        bool IsGameLocked();
        bool IsValidGuess();
        bool IsBetWon();
        bool IsBetLost();

    }
}