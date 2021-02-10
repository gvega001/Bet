using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public interface Group
    {
    
        string GetGroupName();
        void SetGroupName(string groupName);
        Player GetPlayer();
        void SetPlayer(Player player);
        LinkedList<Player> GetPlayers();
        int GetJoinCode(Group group);
        void JoinGroupWithJoinCode(int joinCode, Player player);
        bool GetIsBetOutComeConfirmed();
        bool IsGameConfirmed();
    }
}