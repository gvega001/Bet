using System.Collections.Generic;
using System.Dynamic;

namespace Bet.Models
{
    public interface Game
    {
     
        LinkedList<double> GetScores();
        void SetScore(double score);
        string GetEventName();
        void SetEventName(string eventName);
        double GetGuess();
        void SetGuess(double guess);
        double GetSmallestPossibleGuess();
        void SetSmallestPossibleGuess(double smallestPossibleGuess);
        double GetBiggestPossibleGuess();
        void SetBiggestPossibleGuess(double biggestPossibleGuess);
        LinkedList <Bet> GetBet();
        void SetBets(LinkedList<Bet> betsSets);

        void Reset();
        bool IsGameLocked();
        bool IsValidGuess();
        bool IsBetWon();
        bool IsBetLost();
        bool IsGameConfirmed();
    }
}