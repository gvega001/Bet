using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Web.Security;
using Bet.Controllers;
using Microsoft.Owin.Security.MicrosoftAccount;

namespace Bet.Models
{
    public class Player:User
    {
        [Required]
        [StringLength(250)]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(250)]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }
        [DisplayName("Membership:")]
        public MembershipTypes MembershipType { get; set; }
        [DisplayName("Date of Birth:")]
        public DateTime DateOfBirth { get; set; }
        public new int Id { get; set; }
        [Display(Name = "Subscribe to newsletter")]
        public bool IsSubscribed { get; set; }
        [Required]
        public int MembershipId { get; set; }
        public LinkedList<BetImpl> Bets { get; set; }

    

        //*****========  fields ========*******
     
        private LinkedList<BetImpl> _bets;
        private string _firstName;
        private string _lastName;
        private MembershipTypes _membership;
        
        //******======= constructor ========*******
        public Player(LinkedList<BetImpl> bets, string firstName, string lastName, MembershipTypes membership,
            bool isSubscribed, int membershipId)
        {
            _bets = bets ?? throw new ArgumentNullException(nameof(bets));
            _firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            _lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            _membership = membership;
            IsSubscribed = isSubscribed;
            MembershipId = membershipId;
        }

        public Player()
        {
           
        }
        //*****=======  methods =======********
        void JoinGroup(string joinCode)
        {
            // After implementing groups
        }
        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
            FirstName = _firstName;
        }
        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
            LastName = _lastName;
        }
    }
}