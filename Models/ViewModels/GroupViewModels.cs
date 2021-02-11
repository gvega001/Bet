using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Bet.Models.ViewModels
{
    public class GroupViewModels
    {
        public Group Group { get; set; }
        public LinkedList<BetImpl> Bets { get; set; }
    }
}