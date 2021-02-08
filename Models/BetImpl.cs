using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public class BetImpl: Bet
    {
        public int GetBetId()
        {
            throw new System.NotImplementedException();
        }

        public void SetBetId()
        {
            throw new System.NotImplementedException();
        }

        public SqlMoney GetMoneyBet()
        {
            throw new System.NotImplementedException();
        }

        public void SetMoneyBet(SqlMoney betMoney)
        {
            throw new System.NotImplementedException();
        }

        public Group GetGroup()
        {
            throw new System.NotImplementedException();
        }

        public void SetGroup(Group setGroup)
        {
            throw new System.NotImplementedException();
        }

        public double GetMaxNumber()
        {
            throw new System.NotImplementedException();
        }

        public void SetMaxNumber(double maxNumber)
        {
            throw new System.NotImplementedException();
        }

        public double GetSmallestNumber()
        {
            throw new System.NotImplementedException();
        }

        public void SetSmallestNumber()
        {
            throw new System.NotImplementedException();
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