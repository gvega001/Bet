using System;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public Player Player { get; set; }
        public BetImpl Bet { get; set; }
  
        public LinkedList<BetImpl> Bets { get; set; }
        public PlayerViewModels Details { get; set; }


        public PlayerViewModels GetDetails()
        {

            return (Details);
        }
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