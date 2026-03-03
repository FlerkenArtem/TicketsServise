using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class Event
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private string Orzanizer { get; set; }
        private DateTime EventDateTime { get; set; }
        private string Place { get; set; }
        public Event(Guid id, string name, string orzanizer, DateTime eventDateTime, string place)
        {
            Id = id;
            Name = name;
            Orzanizer = orzanizer;
            EventDateTime = eventDateTime;
            Place = place;
        }
    }
}
