namespace Bet.Models
{
    public interface MessageGenerator
    {
        string GetMainMessage();
        string SetMainMessage();
        string GetResultsMessage();
        string SetResultsMessage();
    }
}