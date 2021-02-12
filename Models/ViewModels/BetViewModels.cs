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
        public BetImpl Bet { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public Group Group { get; set; }
        [Required]
        [Range(0, 1000)]
        [DisplayName("Amount: ")]
        public SqlMoney MoneyBet { get; set; }
        [Range(0, 100000.0)]
        public double MaxPossibleNumber { get; set; }
        [Range(0, 1)]
        public double LowestPossibleNumber { get; set; }

        public double Guess { get; set; }

      
    }
}