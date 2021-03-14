using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bet.DTO
{
    public class NewBetDto
    {
        public int Id { get; set; }

        public GameDto Game { get; set; }

        public GroupDto Group { get; set; }

        public BetDto Bet { get; set; }

        public NewBetDto()
        {
            
        }

        public NewBetDto(int id, GameDto game, GroupDto @group, BetDto bet)
        {
            Id = id;
            Game = game;
            Group = @group;
            Bet = bet;
        }

    }
}