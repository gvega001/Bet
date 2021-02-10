using System.Data.SqlTypes;

namespace Bet.Models.ViewModels
{
    public class BetViewModels
    {
        public Bet Bets { get; set; }
        public Player Player { get; set; }
        public Group Group { get; set; }
        public SqlMoney Money { get; set; }
        public double MaxPossible { get; set; }
        public double LowestPossible { get; set; }
        public Game Game { get; set; }

    }

   
}