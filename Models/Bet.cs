using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public interface Bet
    {

        int Id { get; set; }

        
        [Range(0, 1000)]
        [Display(Name = "Bet Amount: ")]
        int MoneyBet { get; set; }
        [Range(0, 100000.0)]

        double? Guess { get; set; }
      

    }
}