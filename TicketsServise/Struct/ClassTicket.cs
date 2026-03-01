namespace TicketsServise.Struct
{
    public class ClassTicket
    {
        private int _id;
        private string _eventName;
        private decimal _price;
        private DateTime _eventDate;

        public int Id { get { return _id; } set { _id = value; } }
        public string EventName { get { return _eventName; } set { _eventName = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public DateTime EventDate { get { return _eventDate; } set { _eventDate = value; } }

        public ClassTicket(int id, string eventName, decimal price, DateTime eventDate)
        {
            _id = id;
            _eventName = eventName;
            _price = price;
            _eventDate = eventDate;
        }

        public override string ToString()
        {
            return ($"[{Id}] | {EventName} | {Price} | {EventDate}");
        }
    }
}
