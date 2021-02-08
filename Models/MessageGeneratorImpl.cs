namespace Bet.Models
{
    public class MessageGeneratorImpl: MessageGenerator
    {
        private Game _game;
        private MessageGenerator _messageGenerator;
        private string  _mainMessage;
        private string _resultMessage;

        public string GetMainMessage()
        {
            return _mainMessage;
        }

        public void SetMainMessage()
        {
            _mainMessage = _game.ToString();
        }

        public string GetResultsMessage()
        {
            return _resultMessage;
        }

        public void  SetResultsMessage()
        {
            _resultMessage = _game.IsBetWon().ToString();
        }
    }
}