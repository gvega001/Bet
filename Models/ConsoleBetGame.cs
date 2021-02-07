namespace Bet.Models
{
    public class ConsoleBetGame
    {
        private GameImpl _game;
        private MessageGenerator _message;

        public void SetGame(GameImpl gameImpl)
        {
            _game = gameImpl;
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