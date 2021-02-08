using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public class GameImpl :Game
    {
        //*****=======++++++++ fields =========********
        private LinkedList<Bet> bets;
        private LinkedList<double> scoresList;
        private string eventName;
        private double guess;
        private double smallestPossibleNumber;
        private double _largestNumberPossible;
        private Bet _bet;

        

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
            return  eventName;
        }

        public void SetEventName(string eventName)
        {
            this.eventName = eventName;
        }

        public double GetGuess()
        {
            return guess;
        }

        public void SetGuess(double guess)
        {
            this.guess = guess;
        }

        public double GetSmallestPossibleGuess()
        {
            return smallestPossibleNumber;
        }

        public void SetSmallestPossibleGuess()
        {
            this.smallestPossibleNumber = _bet.GetSmallestNumber();
        }

        public double GetBiggestPossibleGuess()
        {
            return _bet.GetMaxNumber();
        }

        public void SetBiggestPossibleGuess()
        {
            this._largestNumberPossible = _bet.GetMaxNumber();
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