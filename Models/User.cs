using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bet.Models
{
    public class User : ApplicationUser
    {
        [Required]
        [StringLength(250)]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(250)]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Membership:")]
        public MembershipTypes MembershipType { get; set; }
        [Required]
        [DisplayName("Date of Birth:")]
        public DateTime DateOfBirth { get; set; }
    }
}