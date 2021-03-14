using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace Bet.Models
{
    public class GameImpl : Game
    {
        public GameImpl()
        {
            
        }

        public GameImpl(LinkedList<Bet> bets, LinkedList<double> scoresList, string eventName, double guess, double smallestPossibleNumber, double largestNumberPossible, Bet bet, GameStatus gameStatus, bool isGameConfirmed, bool isGameLocked, bool isBetConfirmedByAll, Group @group, bool isBetWon)
        {
            _bets = bets;
            _scoresList = scoresList;
            _eventName = eventName;
            _guess = guess;
            _smallestPossibleNumber = smallestPossibleNumber;
            _largestNumberPossible = largestNumberPossible;
            _bet = bet;
            _gameStatus = gameStatus;
            _isGameConfirmed = isGameConfirmed;
            _isGameLocked = isGameLocked;
            _isBetConfirmedByAll = isBetConfirmedByAll;
            _group = @group;
            _isBetWon = isBetWon;
        }

        public string EventName { get; set; }
        public int Id { get; set; }

        public DateTime? EventDateTime { get; set; }
        public DateTime? LastDateTime { get; set; }
       [Required]
        [StringLength(250)]
        public string Team1Name { get; set; }
        public double Team1Score { get; set; }
        [Required]
        [StringLength(250)]
        public string Team2Name { get; set; }
        public double Team2Score { get; set; }

     
        public bool? GameConfirmed { get; set; }

        public bool? BetsConfirmed { get; set; }

        public bool? LockGame { get; set; }

        public bool? GameWon { get; set; }

        //*****=======++++++++ fields =========********
        private LinkedList<Bet> _bets;
        private LinkedList<double> _scoresList;
        private string _eventName;
        private double _guess;
        private double _smallestPossibleNumber;
        private double _largestNumberPossible;
        private Bet _bet;
        private GameStatus _gameStatus;
        private bool _isGameConfirmed;
        private bool _isGameLocked;
        private bool _isBetConfirmedByAll;
        private Group _group;
        private bool _isBetWon;

        public GameImpl(LinkedList<Bet> bets, LinkedList<double> scoresList, string eventName, double guess,
            double smallestPossibleNumber, double largestNumberPossible, Bet bet, GameStatus gameStatus,
            bool isGameConfirmed, bool isGameLocked, bool isBetConfirmedByAll, Group @group, string dateOfEvent,
            string lastDateAndTimeToBest)
        {
            
            _bets = bets ?? throw new ArgumentNullException(nameof(bets));
            _scoresList = scoresList ?? throw new ArgumentNullException(nameof(scoresList));
            _eventName = eventName ?? throw new ArgumentNullException(nameof(eventName));
            _guess = guess;
            _smallestPossibleNumber = smallestPossibleNumber;
            _largestNumberPossible = largestNumberPossible;
            _bet = bet ?? throw new ArgumentNullException(nameof(bet));
            _gameStatus = gameStatus;
            _isGameConfirmed = isGameConfirmed;
            _isGameLocked = isGameLocked;
            _isBetConfirmedByAll = isBetConfirmedByAll;
            _group = @group ?? throw new ArgumentNullException(nameof(@group));
            DateOfEvent = dateOfEvent ?? throw new ArgumentNullException(nameof(dateOfEvent));
            LastDateAndTimeToBest =
                lastDateAndTimeToBest ?? throw new ArgumentNullException(nameof(lastDateAndTimeToBest));
        }
        
        public enum GameStatus
        {
            Running,
            Closed,
            Open,
            Confirmed,
            Locked,
            Won,
            Loss,
            Canceled,
        }

        //********========== public methods ******=============
        public string DateOfEvent { get; set; }

        public LinkedList<double> GetScores()
        {
            return _scoresList;
        }

        public void SetScore(double score)
        {
            _scoresList.AddLast(score);
        }

        public string GetEventName()
        {
            return _eventName;
        }

        public void SetEventName(string eventName)
        {
            this._eventName = eventName;
        }

        public double GetGuess()
        {
            return _guess;
        }

        public void SetGuess(double guess)
        {
            this._guess = guess;
        }

        public double GetSmallestPossibleGuess()
        {
            return _smallestPossibleNumber;
        }

     

        public double GetBiggestPossibleGuess()
        {
            return _largestNumberPossible;
        }

       
        public LinkedList<Bet> GetBet()
        {
            return _bets;
        }

        public void SetBets(LinkedList<Bet> betsSets)
        {
            try
            {
                //set bets
                _bets = betsSets;
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
            return _isGameLocked;
        }

      

        public bool IsBetWon()
        {

            foreach (var bet in _bets)
            {
                int count = 0;
                if (_isBetConfirmedByAll== true)
                {
                    _gameStatus = GameStatus.Won;

                }
                else if (_isBetConfirmedByAll == false)
                {
                    _gameStatus = GameStatus.Canceled;
                    count++;
                }

                if (count >= 1)
                {
                    _gameStatus = GameStatus.Closed;
                    _isBetWon = true;
                }
                else if (count == 0)
                {
                    _gameStatus = GameStatus.Canceled;

                }
            }

            return _isBetConfirmedByAll;
        }

        public bool IsBetLost()
        {
            return !_isBetWon;
        }

        public bool IsGameConfirmed()
        {
            return _isGameConfirmed;
        }

        public bool IsValidGuess()
        {
            if (IsValidGuess())
            {
                return true;
            }

            return false;
        }

        public string LastDateAndTimeToBest { get; set; }
        
    }

}
