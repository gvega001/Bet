using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bet.Models;

namespace Bet.DTO
{
    public class GroupDto
    {
        public GroupDto()
        {
            
        }

        public GroupDto(int id, string groupName, int joinCode, LinkedList<BetImpl> bets)
        {
            Id = id;
            GroupName = groupName;
            JoinCode = joinCode;
            Bets = bets;
        }
        
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        [Required]
        public int JoinCode { get; set; }

        public LinkedList<BetImpl> Bets { get; set; }

    }
}