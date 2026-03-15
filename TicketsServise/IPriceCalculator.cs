namespace TicketsServise
{
    public interface IPriceCalculator
    {
        decimal Calculate(IEnumerable<Ticket> tickets);
    }
}
