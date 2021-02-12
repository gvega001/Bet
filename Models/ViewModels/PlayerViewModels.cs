using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public int Id { get; set; }
        public Player Player { get; set; }

        public IEnumerable<BetImpl> Bets { get; set; }
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

    public class NewPlayerViewModels
    {
        public Player Player { get; set; }

    }

}