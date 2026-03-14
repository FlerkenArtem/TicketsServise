using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public interface IPriceCalculator
    {
        decimal Calculate(IEnumerable<Ticket> tickets);
    }
}
