using System;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public Player Player { get; set; }
        public BetImpl Bet { get; set; }
  

    }

    public class Details
    {
        public BetImpl Bet { get; set; }
        
        public LinkedList<BetImpl> Bets { get; set; }

    }

}