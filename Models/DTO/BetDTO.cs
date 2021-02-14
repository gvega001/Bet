using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Bet.Models.DTO
{
    public class BetDTO
    {
   
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public Group Group { get; set; }
        [Required]
        [Range(0, 1000)]
        [Display(Name = "Amount: ")]
        public SqlMoney? MoneyBet { get; set; }
        [Range(0, 100000.0)]
        public double? MaxPossibleNumber { get; set; }
        [Range(0, 1)]
        public double? LowestPossibleNumber { get; set; }

        public double Guess { get; set; }
        public int? GameId { get; set; }
    }
}