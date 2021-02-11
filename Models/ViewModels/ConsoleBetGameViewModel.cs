using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bet.Models.ViewModels
{
    public class ConsoleBetGameViewModel
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public HashSet<string> Teams { get; set; }
      
        [StringLength(250)]
        public string TeamName { get; set; }
        public double TeamScore { get; set; }

        [StringLength(250)]
        public double PlayerGuess { get; set; }
        [Range(0, 1.0)]
        public double SmallestPossibleNumber { get; set; }
        [Range(0, 100000.0)]
        public double LargestPossibleNumber { get; set; }
        [Required]
        public LinkedList<BetImpl> Bets { get; set; }
        [Required]
        public Group Group { get; set; }

        public bool GameConfirmed { get; set; }

        public bool BetsConfirmed { get; set; }

        public bool LockGame { get; set; }

        public bool GameWon { get; set; }
        public Player Player { get; set; }
        public Game Game { get; set; }
        public Bet Bet { get; set; }
       
    }
}