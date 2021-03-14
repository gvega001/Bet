using System;

namespace Bet.Models
{
    public class MessageGeneratorImpl: MessageGenerator
    {
        
        public Game Game { get; set; }

        public MessageGeneratorImpl Message { get; set; }

        public string MainMessage { get; set; }

        public string ResultsMessage { get; set; }

        //*****======= fields **********============
        private Game _game;
        private MessageGenerator _messageGenerator;
        private string  _mainMessage;
        private string _resultMessage;

        public MessageGeneratorImpl(Game game, MessageGenerator messageGenerator, string mainMessage,
            string resultMessage)
        {
            _game = game ?? throw new ArgumentNullException(nameof(game));
            _messageGenerator = messageGenerator ?? throw new ArgumentNullException(nameof(messageGenerator));
            _mainMessage = mainMessage ?? throw new ArgumentNullException(nameof(mainMessage));
            _resultMessage = resultMessage ?? throw new ArgumentNullException(nameof(resultMessage));
        }

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
            _resultMessage = _game.GameWon.ToString();
        }
    }
}