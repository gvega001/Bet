using System;
using System.Collections.Generic;
using System.Web.Security;
using Bet.Controllers;
using Microsoft.Owin.Security.MicrosoftAccount;

namespace Bet.Models
{
    public class Player:ApplicationUser
    {

        //*****========  fields ========*******
        internal Random PlayerId;
        private ApplicationUser _user;


        //******======= constructor ========*******
        public Player(Random playerId)
        {
            
            PlayerId = playerId ?? throw new ArgumentNullException(nameof(playerId));

        }

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