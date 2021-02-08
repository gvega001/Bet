using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public class GameImpl :Game
    {
        //*****=======++++++++ fields =========********
        private LinkedList<Bet> bets;
        private LinkedList<double> scoresList;


        //********========== public methods ******=============
        public string DateOfEvent { get; set; }
    
        public LinkedList<double> GetScores()
        {
            return scoresList;
        }
        public void SetScore(double score)
        {
            scoresList.AddLast(score);
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
            try
            {
                //set bets
                bets = betsSets;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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