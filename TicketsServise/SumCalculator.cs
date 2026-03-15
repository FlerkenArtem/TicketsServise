namespace TicketsServise
{
    public class SumCalculator : IPriceCalculator
    {
        public decimal Calculate(IEnumerable<Ticket> tickets)
        {
            return tickets.Sum(t => t.price);
        }
    }
}
