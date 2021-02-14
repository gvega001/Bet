using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Bet.Models
{
    public interface Bet
    {
        double GetMaxNumber();
        void SetMaxNumber(double maxNumber);
        double GetSmallestNumber();
        void SetSmallestNumber(double minNumber);

    }
}