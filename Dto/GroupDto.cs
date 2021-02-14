using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bet.Models;

namespace Bet.DTO
{
    public class GroupDto
    {
        public int Id { get; set; }
        public int? BetId { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        public int? PlayerId { get; set; }
        [Required]
        public int JoinCode { get; set; }

        public LinkedList<BetImpl> Bets { get; set; }

        public int? GameId { get; set; }
    }
}