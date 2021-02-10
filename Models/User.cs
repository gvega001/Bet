using System.ComponentModel.DataAnnotations;

namespace Bet.Models
{
    public class User : ApplicationUser
    {
        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(250)]
        public string LastName { get; set; }
    
        public MembershipTypes MembershipType { get; set; }
    }
}