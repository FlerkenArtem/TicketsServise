using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TicketsServise
{
    public class EventsInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Performers { get; set; }
        public BigInteger TicketsAvailable { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string Genge { get; set; }
        public string DateTime { get; set; }
        public EventsInfo(
            Guid id, 
            string name, 
            string performers, 
            BigInteger ticketsAvailable, 
            string city, 
            string place, 
            string type, 
            string genge, 
            string dateTime)
        {
            Id = id;
            Name = name;
            Performers = performers;
            TicketsAvailable = ticketsAvailable;
            City = city;
            Place = place;
            Type = type;
            Genge = genge;
            DateTime = dateTime;
        }
        public override string ToString()
        {
            return $"{Name} - {Performers} - {Place} - {DateTime} - Доступно билетов: {TicketsAvailable}";
        }
    }
}
