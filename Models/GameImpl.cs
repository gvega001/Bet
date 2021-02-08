using System.Collections.Generic;

namespace Bet.Models
{
    public class GameImpl :Game
    {
        public string DateOfEvent { get; set; }
        public double GetScore()
        {
            throw new System.NotImplementedException();
        }

        public void SetScore(double score)
        {
            throw new System.NotImplementedException();
        }

        public string GetEventName()
        {
            throw new System.NotImplementedException();
        }

        public void SetEventName(string eventName)
        {
            throw new System.NotImplementedException();
        }

        public double GetGuess()
        {
            throw new System.NotImplementedException();
        }

        public void SetGuess(double guess)
        {
            throw new System.NotImplementedException();
        }

        public double GetSmallestPossibleGuess()
        {
            throw new System.NotImplementedException();
        }

        public void SetSmallestPossibleGuess(double smallestPossibleNumber)
        {
            throw new System.NotImplementedException();
        }

        public double GetBiggestPossibleGuess()
        {
            throw new System.NotImplementedException();
        }

        public void SetBiggestPossibleGuess(double biggestPossibleNumber)
        {
            throw new System.NotImplementedException();
        }

        public LinkedList<Bet> GetBetImpl()
        {
            throw new System.NotImplementedException();
        }

        public void SetBets(LinkedList<Bet> betsSets)
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public bool IsGameLocked()
        {
            throw new System.NotImplementedException();
        }

        public void LockGame()
        {
            throw new System.NotImplementedException();
        }

        public bool IsValidGuess()
        {
            throw new System.NotImplementedException();
        }

        public bool IsBetWon()
        {
            throw new System.NotImplementedException();
        }

        public bool IsBetLost()
        {
            throw new System.NotImplementedException();
        }

        public bool IsGameConfirmed()
        {
            throw new System.NotImplementedException();
        }

        public void ConfirmGame(LinkedList<Player> atLeastTwoPlayers)
        {
            throw new System.NotImplementedException();
        }
    }
}