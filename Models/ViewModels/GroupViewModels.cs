using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace Bet.Models.ViewModels
{
    public class GroupViewModels
    {
        public GroupViewModels(){}
        public GroupViewModels(int id, int betId, string groupName, Player player, LinkedList<Player> players, int joinCode, BetImpl bet, LinkedList<BetImpl> bets, bool gameIsConfirmed, bool betsAreConfirmed, Group @group)
        {
           
        }
        public int Id { get; set; }
        public int BetId { get; set; }
        [Required]
        [StringLength(250)]
        public string GroupName { get; set; }
        [Required]
        public Player Player { get; set; }
        [Required]
        public LinkedList<Player> Players { get; set; }
        [Required]
        public int JoinCode { get; set; }

        public BetImpl Bet { get; set; }
        [Required]
        public LinkedList<BetImpl> Bets { get; set; }

        public bool GameIsConfirmed { get; set; }
        public bool BetsAreConfirmed { get; set; }
        public GroupImpl Group { get; set; }
       
    }
}