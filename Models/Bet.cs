using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public interface Bet
    {
        SqlMoney GetMoney();
        SqlMoney SetMoney();
        LinkedList<Group> GetGroups();
        LinkedList<Group> SetGroups();
        int GetMaxNumber();
        int GetSmallestNumber();
        bool IsBetConfirmed();
    }
}