using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bet.Models;

namespace Bet.DTO
{
    public class GameDto
    {
        public string EventName { get; set; }
        public int Id { get; set; }
     
        public DateTime? EventDateTime { get; set; }
        public DateTime? LastDateTime { get; set; }
  
        [Required]
        [StringLength(250)]
        public string Team1Name { get; set; }
        public double Team1Score { get; set; }
        [Required]
        [StringLength(250)]
        public string Team2Name { get; set; }
        public double Team2Score { get; set; }
       
        public bool? GameConfirmed { get; set; }

        public bool? BetsConfirmed { get; set; }

        public bool? LockGame { get; set; }

        public bool? GameWon { get; set; }

    }
}