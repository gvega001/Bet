using System;
using System.Collections.Generic;
using System.Web.Security;
using Bet.Controllers;
using Microsoft.Owin.Security.MicrosoftAccount;

namespace Bet.Models
{
    public class Player:User
    {

        //*****========  fields ========*******
        internal Random PlayerId;
        private LinkedList<Bet> _bets;
        private string _firstName;
        private string _lastName;
        private MembershipTypes _membership;
        
        //******======= constructor ========*******
        public Player(MembershipTypes membership)
        {
           
            _membership = membership;
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