namespace TicketsServise
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Orzanizer { get; set; }
        public DateTime EventDateTime { get; set; }
        public string Place { get; set; }
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
