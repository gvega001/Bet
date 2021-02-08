using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public interface Group
    {
        Random GetGroupId();
        void SetGroupId();
        string GetGroupName();
        void SetGroupName(string groupName);
        Player GetPlayer();
        void SetPlayer(Player player);
        LinkedList<Player> GetPlayers();
        int GetJoinCode(Group group);
        void JoinGroupWithJoinCode(int joinCode, Player player);
    }
}