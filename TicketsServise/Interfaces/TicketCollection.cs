using Npgsql.TypeMapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TicketsServise.Interfaces
{
    public class TicketCollection : IEnumerable<Ticket>, IComparable<TicketCollection>, ICloneable, IDisposable
    {
        private List<Ticket> _ticketList = new List<Ticket>();

        private bool _disposed;

        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        public void AddTicket(Ticket ticket)
        {
            _ticketList.Add(ticket);
        }

        public bool RemoveTicket(Ticket ticket)
        {
            return _ticketList.Remove(ticket);
        }

        public decimal totalPrice => _ticketList.Sum(t => t.TicketPrice);

        public int cnt => _ticketList.Count;

        public Ticket this[int index] => _ticketList[index]; // индексатор для доступа к билету в коллекции по его позиции

        // реализация перечислителя для возможности перебора элементов коллекции с помощью foreach
        public IEnumerator<Ticket> GetEnumerator() => _ticketList.GetEnumerator(); 
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int CompareTo(TicketCollection other) // сравнение коллекций билетов по стоимости
        {
            if (other == null) return 1;
            return totalPrice.CompareTo(other.totalPrice);
        }

        public object Clone() // копия коллекции
        {
            var clone = new TicketCollection();
            foreach (var ticket in _ticketList) 
            {
                clone.AddTicket((Ticket)ticket.Clone());
            }
            return clone;
        }

        public void Dispose() // освобождение ресурсов
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
                    foreach (var ticket in _ticketList)
                    {
                        ticket?.Dispose();
                    }
                    _ticketList.Clear();
                }
                _disposed = true;
            }
        }

        ~TicketCollection() 
        {
            Dispose(false);
        }

        public override string ToString() // строковое представление заказа
        {
            return $"Заказчик: {CustomerName} | Дата: {OrderDate} | Билетов: {cnt} | Сумма: {totalPrice}";
        }
    }
}
