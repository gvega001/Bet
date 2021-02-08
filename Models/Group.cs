using System.Collections.Generic;

namespace Bet.Models
{
    public interface Group
    {
        int GetGroupId();
        void SetGroupId();
        string GetGroupName();
        void SetGroupName(string groupName);
        Player GetPlayer();
        void SetPlayer(Player player);
        LinkedList<Player> GetPlayers();
        void SetPlayers(LinkedList<Player> atLeastTwoPlayers);
        string GetJoinCode();
        void SetJoinCode();
    }
}