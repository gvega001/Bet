namespace Bet.Models.ViewModels
{
    public class ConsoleBetGameViewModel
    {
        public Player Player { get; set; }
        public Game Game { get; set; }
        public Bet Bet { get; set; }
        public Group Group { get; set; }
        public MessageGenerator MessageGenerator { get; set; }
    }
}