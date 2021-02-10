using System;
using System.Collections.Generic;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public Player Player { get; set; }
        public BetImpl Bet { get; set; }
  

    }

    public class BetDetails
    {
        public LinkedList<BetImpl> Bets { get; set; }
    }

}