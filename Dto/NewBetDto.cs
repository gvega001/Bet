using System.Collections.Generic;

namespace Bet.DTO
{
    public class NewBetDto
    {
        public int GroupId { get; set; }

        public int GameId { get; set; }

        public List<int> BetIds { get; set; }


    }
}