using System.Collections.Generic;
using System.Dynamic;

namespace Bet.Models
{
    public interface Game
    {
        string DateOfEvent { get; set; }
        double GetScore();
        void SetScore(double score);
        string GetEventName();
        void SetEventName(string eventName);
        double GetGuess();
        void SetGuess(double guess);
        double GetSmallestPossibleGuess();
        void SetSmallestPossibleGuess(double smallestPossibleNumber);
        double GetBiggestPossibleGuess();
        void SetBiggestPossibleGuess(double biggestPossibleNumber);
        LinkedList <Bet> GetBetImpl();
        void SetBets(LinkedList<Bet> betsSets);

        void Reset();
        bool IsGameLocked();
        void LockGame();
        bool IsValidGuess();
        bool IsBetWon();
        bool IsBetLost();
        bool IsGameConfirmed();
        void ConfirmGame(LinkedList<Player> atLeastTwoPlayers);
    }
}