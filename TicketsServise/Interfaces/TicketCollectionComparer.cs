namespace TicketsServise.Interfaces
{
    public class TicketCollectionComparer : IComparer<TicketCollection>
    {
        public int Compare(TicketCollection x, TicketCollection y) // сравнение количества билетов в коллекциях x и y
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.cnt.CompareTo(y.cnt);
        }
    }
}
