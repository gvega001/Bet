using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Web.Security;
using Bet.Controllers;
using Microsoft.Owin.Security.MicrosoftAccount;

namespace Bet.Models
{
    public class Player:User
    {
        public bool IsSubscribed { get; set; }

        public int MembershipId { get; set; }

        public LinkedList<BetImpl> Bets { get; set; }

    

        //*****========  fields ========*******
     
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

    }
}