namespace TicketsServise
{
    public class CardDataFilledHandler : ValidationHandler
    {
        private static readonly Guid _cardPaymentTypeId = Constants.CardPaymentTypeId;
        public override bool Handle(BuyTicket context, out string errorMessage)
        {
            if (context.SelectedPaymentType == _cardPaymentTypeId)
            {
                if (string.IsNullOrWhiteSpace(context.CardNumber) ||
                    string.IsNullOrWhiteSpace(context.ValidThru) ||
                    string.IsNullOrWhiteSpace(context.Cvv2))
                {
                    errorMessage = "Заполните все данные карты.";
                    return false;
                }
            }
            if (_next != null)
                return _next.Handle(context, out errorMessage);
            errorMessage = null;
            return true;
        }
    }
}
