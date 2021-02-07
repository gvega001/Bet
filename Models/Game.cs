using System.Collections.Generic;
using System.Dynamic;

namespace Bet.Models
{
    public interface Game
    {
        string DateOfEvent { get; set; }
        int GetScore();
        int SetScore();
        string GetEventName();
        string SetEventName();
        int GetGuess();
        int SetGuess();
        int GetSmallestPossibleGuess();
        int SetSmallestPossibleGuess();
        int GetBiggestPossibleGuess();
        int SetBiggestPossibleGuess();
        LinkedList <Bet> GetBetImpl();
        LinkedList<Bet> SetBets();

        void Reset();
        bool IsGameLocked();
        bool IsValidGuess();
        bool IsBetWon();
        bool IsBetLost();

    }
}