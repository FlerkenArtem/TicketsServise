using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class Ticket
    {
        public Guid id { get; set; }
        public string place { get; set; }
        public decimal price { get; set; }

        public Ticket(Guid id, string place, decimal price)
        {
            this.place = place;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{place} - цена: {price} руб. ";
        }
    }
}
