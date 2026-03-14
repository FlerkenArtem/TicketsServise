using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class PaymentMethodSelectedHandler : ValidationHandler
    {
        public override bool Handle(BuyTicket context, out string errorMessage)
        {
            if (context.SelectedPaymentType == null)
            {
                errorMessage = "Выберите способ оплаты.";
                return false;
            }
            if (_next != null)
                return _next.Handle(context, out errorMessage);
            errorMessage = null;
            return true;
        }
    }
}
