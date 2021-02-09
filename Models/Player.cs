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
        private Player _player;
        private ApplicationUser user;
        
        //******======= constructor ========*******
        public Player( )
        {
            PlayerId = new Random(Int32.MaxValue);
        }

        //*****=======  methods =======********
        void JoinGroup(string joinCode)
        {
            // After implementing groups
        }


        private Random GetPlayerId(ApplicationUser user)
        {
            return PlayerId;
        }
    }
}