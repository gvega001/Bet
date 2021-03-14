using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Bet.Models
{
    public interface Game
    {
     
        LinkedList<double> GetScores();
        void SetScore(double score);
        string EventName { get; set; }
        int Id { get; set; }
        DateTime? EventDateTime { get; set; }
        DateTime? LastDateTime { get; set; }
        [Required]
        [StringLength(250)]
        string Team1Name { get; set; }
        double Team1Score { get; set; }
        [Required]
        [StringLength(250)]
        string Team2Name { get; set; }
        double Team2Score { get; set; }


        bool? GameConfirmed { get; set; }

        bool? BetsConfirmed { get; set; }

        bool? LockGame { get; set; }

        bool? GameWon { get; set; }
    }
}