using System.ComponentModel.DataAnnotations;
using Bet.DTO;

namespace Bet.Models
{
    public class NewBet
    {
        public NewBet()
        {
            
        }

        public NewBet(int id, GameDto game, GroupDto @group, BetDto bet)
        {
            Id = id;
            Game = game;
            Group = @group;
            Bet = bet;
        }

        public int Id { get; set; }

        public GameDto Game { get; set; }

        public GroupDto Group { get; set; }

        public BetDto Bet { get; set; }


    }
}