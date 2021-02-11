

using System.Security.AccessControl;

namespace Bet.Models
{
    public class ConsoleBetGame
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public MessageGeneratorImpl MessageGeneratorImpl { get; set; }

        private Game _game;
        private MessageGenerator _message;

        public void SetGame(Game game)
        {
            _game = game;
        }

        public Game GetGame()
        {

            return _game;
        }

        public void SetMessageGenerator(MessageGeneratorImpl messageImpl)
        {
            _message = messageImpl;
        }

        public MessageGenerator GetMessage()
        {

            return _message;
        }
    }
}