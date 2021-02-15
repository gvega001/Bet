using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Bet.Models.ViewModels
{
    
    public class BetViewModels
    {
   
        public int Id { get; set; }


    }

    public class BetFormViewModels
    {
   
        public BetImpl Bet { get; set; }
        
    }
}