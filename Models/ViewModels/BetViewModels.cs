using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Bet.Models.ViewModels
{
    public class BetViewModels
    {
        public int Id { get; set; }
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
     
        public Bet Bets { get; set; }
        public Player Player { get; set; }
     
        public Game Game { get; set; }

    }

   
}