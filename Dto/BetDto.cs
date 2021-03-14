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

        public BetDto(string gameName, int id, int? groupId, int moneyBet, double? guess, int? gameId)
        {
            GameName = gameName;
            Id = id;
            GroupId = groupId;
            MoneyBet = moneyBet;
            Guess = guess;
            GameId = gameId;
        }
        public string GameName { get; set; }
        [Range(0, 1000)]
        public int Id { get; set; }

        public int? GroupId { get; set; }

      
        [Display(Name = "Bet Amount: ")]
        public int MoneyBet { get; set; }
        [Range(0, 100000.0)]

        public double? Guess { get; set; }
        
        public int? GameId { get; set; }
    }
}