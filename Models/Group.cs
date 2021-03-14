using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public interface Group
    {
    
        string GetGroupName();
        void SetGroupName(string groupName);
     
        int GetJoinCode(Group group);
        void JoinGroupWithJoinCode(int joinCode, Player player);
        bool GetIsBetOutComeConfirmed();
        bool IsGameConfirmed();
    }
}