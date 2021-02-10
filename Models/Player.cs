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

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public string GetLasttName()
        {
            return _lastName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
    }
}