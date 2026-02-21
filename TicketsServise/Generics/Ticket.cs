using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise.Generics
{
    public class Ticket
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public decimal Price { get; set; }
        public DateTime EventDate { get; set; }
        public Ticket(int id, string eventName, decimal price, DateTime eventDate)
        {
            Id = id;
            EventName = eventName;
            Price = price;
            EventDate = eventDate;
        }
        public override string ToString() 
        {
            return $"[{Id}] {EventName} – {Price:C} ({EventDate:d})";
        }
    }
}
