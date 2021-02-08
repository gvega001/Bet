using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public class Player:ApplicationUser
    {
        
        //*****========  fields ========*******
        private LinkedList<Group> playerGroups;
        internal Random playerId;

        //*****=======  methods =======********
        public LinkedList<Group> GetGroups(Player player)
        {
            return playerGroups;
        }

        void JoinGroup(string joinCode)
        {
            // After implementing groups
        }
        private void SetPlayerId()
        {
            Random randomNumber = new Random(DateTime.Now.GetHashCode());
            playerId = randomNumber;
        }
    }
}