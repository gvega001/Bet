using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Microsoft.Owin.Security.Provider;

namespace Bet.Models
{
    public class BetImpl: Bet
    {
        public int Id { get; set; }

        public int? GroupId { get; set; }

        public string GameName { get; set; }
        [Range(0, 1000)]
        [Display(Name = "Bet Amount: ")]
        public int MoneyBet { get; set; }
        [Range(0, 100000.0)]

        public double? Guess { get; set; }
        public int? GameId { get; set; }

        //***===========   public fields *********=========
        private readonly Player _player;
        private Group _betGroup;
        private Random _betId;
        private SqlMoney _betMoney;
        private double _maxScorePossible;
        private double _lowestScorePossible;
        private Game _game;
        

        //*****======  Constructor ************=================
        public BetImpl(Player player, Group betGroup, SqlMoney betMoney, double maxScorePossible,
            double lowestScorePossible, Game game)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _betGroup = betGroup ?? throw new ArgumentNullException(nameof(betGroup));
            _betId = new Random(Int32.MaxValue); 
            _betMoney = betMoney;
            _maxScorePossible = maxScorePossible;
            _lowestScorePossible = lowestScorePossible;
            _game = game ?? throw new ArgumentNullException(nameof(game));
        }

        public void SetGame(Game game)
        {
            _game = game;
        }

        public Game GetGame()
        {
            return _game;
        }
        public enum BetStatus
        {
            Valid, Invalid,
        }

        //***===========  public methods *********===========


        public SqlMoney GetMoneyBet()
        {
            return _betMoney;
        }

        public void SetMoneyBet(SqlMoney betMoney)
        {
            this._betMoney = betMoney;
        }

        public Group GetGroup()
        {
            return _betGroup;
        }

        public void SetGroup(Group setGroup)
        {
            this._betGroup = setGroup;
        }

        public double GetMaxNumber()
        {

            return _maxScorePossible;
        }

        public void SetMaxNumber(double maxNumber)
        {
            this._maxScorePossible = maxNumber;
        }

        public double GetSmallestNumber()
        {
            return _lowestScorePossible;
        }

        public void SetSmallestNumber(double lowestNumberPossible)
        {
            this._lowestScorePossible = lowestNumberPossible;
        }

        public bool IsBetConfirmed()
        {
            if (_betGroup.GetIsBetOutComeConfirmed())
            {
                return true;
            }

            return false;
        }

        public bool ConfirmBet(LinkedList<Player> atLeastTwoPlayers)
        {
            int count = 0;
            bool checkPlayer = false;
            foreach (var check  in atLeastTwoPlayers)
            {
                if (atLeastTwoPlayers.Find(_player) !=null )
                {
                    checkPlayer = true;
                    count++;
                }
                else if (atLeastTwoPlayers.Find(_player)==null)
                {
                    checkPlayer = false;
                }
            }

            if (count >= 2 && checkPlayer)
            {
                return true;
            }

            return false;
        }

        public bool PaymentsConfirmed(LinkedList<Player> playersPaymentList)
        {
            foreach (var confirmPaymentPlayer in playersPaymentList)
            {
                if (_game.IsGameConfirmed() == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}