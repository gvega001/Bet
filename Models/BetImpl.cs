using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Microsoft.Owin.Security.Provider;

namespace Bet.Models
{
    public class BetImpl: Bet
    {
        //***===========   private fields *********=========
        private readonly Player _player;
        private Group _betGroup;
        private Random _betId;
        private SqlMoney _betMoney;
        private double _maxScorePossible;
        private double _lowestScorePossible;
        private Game _game;
        

        //*****======  Constructor ************=================
        public BetImpl(Player player, Group betGroup, Random betId, SqlMoney betMoney, double maxScorePossible,
            double lowestScorePossible, Game game)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _betGroup = betGroup ?? throw new ArgumentNullException(nameof(betGroup));
            _betId = betId ?? throw new ArgumentNullException(nameof(betId));
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
        public Random GetBetId()
        {
            return _betId;
        }

        public void SetBetId()
        {
            _betId = new Random(Int32.MaxValue);
        }

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