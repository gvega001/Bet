using System;

namespace Bet.Models.ViewModels
{
    public class PlayerViewModels
    {
        public Player _player = new Player();
        public Random PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}