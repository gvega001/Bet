using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Bet.Models;

namespace Bet.DTO
{
    public class BetDto
    {
        public int Id { get; set; }

        public int? GroupId { get; set; }

        public string GameName { get; set; }
        [Range(0, 1000)]
        [Display(Name = "Bet Amount: ")]
        public int MoneyBet { get; set; }
        [Range(0, 100000.0)]

        public double? Guess { get; set; }
        public int? GameId { get; set; }
    }
}