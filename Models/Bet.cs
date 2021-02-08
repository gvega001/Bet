using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public interface Bet
    {
        int GetBetId();
        void SetBetId();
        SqlMoney GetMoneyBet();
        void SetMoneyBet(SqlMoney betMoney);
        Group GetGroup();
        void SetGroup(Group setGroup);
        double GetMaxNumber();
        void SetMaxNumber(double maxNumber);
        double GetSmallestNumber();
        void SetSmallestNumber();
        bool IsBetConfirmed();
        void ConfirmBet(LinkedList<Player> atLeastTwoPlayers);

        bool PaymentsConfirmed(LinkedList<Player> playersPaymentList);
    }
}