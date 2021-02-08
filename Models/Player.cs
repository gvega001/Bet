using System;
using System.Collections.Generic;

namespace Bet.Models
{
    public class Player:ApplicationUser
    {
        
        //*****========  fields ========*******
        internal Random PlayerId;

        //*****=======  methods =======********
   
        void JoinGroup(string joinCode)
        {
            // After implementing groups
        }
        private void SetPlayerId()
        {
            PlayerId = new Random(Int32.MaxValue);
        }
    }
}