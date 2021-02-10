namespace Bet.Models
{
    public class User : ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Subscribed { get; set; }
        public MembershipTypes MembershipType { get; set; }
    }
}