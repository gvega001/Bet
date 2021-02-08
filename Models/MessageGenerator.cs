namespace Bet.Models
{
    public interface MessageGenerator
    {
        string GetMainMessage();
        void SetMainMessage();
        string GetResultsMessage();
        void SetResultsMessage();
    }
}