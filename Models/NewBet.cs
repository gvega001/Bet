using System.ComponentModel.DataAnnotations;
using Bet.DTO;

namespace Bet.Models
{
    public class NewBet : Bet
    {
        public int Id { get; set; }

        public GameDto Game { get; set; }

        public GroupDto Group { get; set; }

        [Range(0, 1000)]
        [Display(Name = "Bet Amount: ")]
        public int MoneyBet { get; set; }

        [Range(0, 100000.0)] public double? Guess { get; set; }

        public double GetMaxNumber()
        {
            throw new System.NotImplementedException();
        }

        public void SetMaxNumber(double maxNumber)
        {
            throw new System.NotImplementedException();
        }

        public double GetSmallestNumber()
        {
            throw new System.NotImplementedException();
        }

        public void SetSmallestNumber(double minNumber)
        {
            throw new System.NotImplementedException();
        }

    }
}