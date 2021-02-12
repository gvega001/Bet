using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Bet.Models.ViewModels
{
    
    public class BetViewModels
    {
        public BetViewModels(Player player)
        {
            
        }
        public Player Player { get; set; }
        public int Id { get; set; }
       public IEnumerable<BetImpl> Bets { get; set; }
       public Game Game { get; set; }
       public BetImpl Bet { get; set; }

    }

    public class NewBetViewModels
    {
        public NewBetViewModels()
        {
            
        }
        public BetImpl Bet { get; set; }
        
    }
}