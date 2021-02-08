using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public class BetImpl: Bet
    {
        //***===========   private fields *********=========
        private Group _betGroup;
        private Random _betId;
        private SqlMoney _betMoney;
        private double _maxScorePossible;
        private double _lowestScorePossible;
        


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
            throw new System.NotImplementedException();
        }

        public void ConfirmBet(LinkedList<Player> atLeastTwoPlayers)
        {
            throw new System.NotImplementedException();
        }

        public bool PaymentsConfirmed(LinkedList<Player> playersPaymentList)
        {
            throw new System.NotImplementedException();
        }
    }
}