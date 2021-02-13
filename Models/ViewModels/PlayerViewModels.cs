using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public int Id { get; set; }
        public Player Player { get; set; }
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

        [Display(Name = "Subscribe to newsletter")]
        public bool IsSubscribed { get; set; }
      
        public int MembershipId { get; set; }

    }

    public class GetBets
    {
        public LinkedList<BetImpl> Bets;
        public Player GetPlayer { get; set; }


        public LinkedList<BetImpl> GetBetImpl()
        {
            return GetPlayer.Bets;
        }

    }


}