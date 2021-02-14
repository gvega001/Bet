using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bet.Models.ViewModels
{
    public class ConsoleBetGameViewModel
    {
        public int Id { get; set; }
        public GameImpl GameImpl { get; set; }
    }
}