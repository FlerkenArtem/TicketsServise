namespace TicketsServise.Interfaces
{
    public class Ticket : IComparable<Ticket>, ICloneable, IDisposable
    {
        private MemoryStream _stream; // класс из пространства имен, который позволяет работать с данными в оперативной памяти как с потоком байт
        // используем MemoryStream для демонстрации интерфейса IDisposable
        private bool _disposed = false;
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public decimal TicketPrice { get; set; }
        public Ticket(int id, string eventName, DateTime eventDate, decimal ticketPrice)
        {
            Id = id;
            EventName = eventName;
            EventDate = eventDate;
            TicketPrice = ticketPrice;
            _stream = new MemoryStream(new byte[] { 1, 2, 3, 4, 5 }); // имитация данных для MemoryStream с помощью массива байт, содержащего числа
        }
        public int CompareTo(Ticket other) // сортировка по цене
        {
            if (other == null)
                return 1;
            return TicketPrice.CompareTo(other.TicketPrice);
        }
        public object Clone() // копирование данных билета 
        {
            Ticket clone = new Ticket(Id, EventName, EventDate, TicketPrice);
            clone._stream = new MemoryStream(_stream.ToArray());
            return clone;
        }
        // освобождение ресурсов
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    _stream?.Dispose();
                    _stream = null;
                }
                _disposed = true;
            }
        }
        ~Ticket()
        {
            Dispose(false);
        }
        public override string ToString()
        {
            return $"[{Id}] {EventName} | {EventDate} | {TicketPrice}";
        }
    }
}
