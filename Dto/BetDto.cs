using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Bet.Models;

namespace Bet.DTO
{
    public class BetDto
    {
        public BetDto()
        {
            

        }

        public BetDto(int id, int moneyBet, double? guess, string team)
        {
            Id = id;
            MoneyBet = moneyBet;
            Guess = guess;
            Team = team;
        }
        public int Id { get; set; }


        [Range(0, 1000)]
        [Display(Name = "Bet Amount: ")]
        public int MoneyBet { get; set; }
        [Range(0, 100000.0)]

        public double? Guess { get; set; }

        public string Team { get; set; }
    }
}