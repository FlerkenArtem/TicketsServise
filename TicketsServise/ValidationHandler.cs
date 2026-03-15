namespace TicketsServise
{
    public abstract class ValidationHandler
    {
        protected ValidationHandler _next;
        public void SetNext(ValidationHandler next)
        {
            _next = next;
        }
        public abstract bool Handle(BuyTicket context, out string errorMessage);
    }
}
