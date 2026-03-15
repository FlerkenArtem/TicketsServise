namespace TicketsServise
{
    public class CartNotEmptyHandler : ValidationHandler
    {
        public override bool Handle(BuyTicket context, out string errorMessage)
        {
            if (context.TicketsCount == 0)
            {
                errorMessage = "Корзина пуста.";
                return false;
            }
            if (_next != null)
                return _next.Handle(context, out errorMessage);
            errorMessage = null;
            return true;
        }
    }
}
