namespace TicketsServise
{
    public abstract class UserState
    {
        protected MainWindow _context;
        public void SetContext(MainWindow context) => _context = context;
        public abstract void Enter();
        public abstract void Exit();
        public abstract bool CanBuyTickets { get; }
        public abstract bool CanCreateEvent { get; }
        public abstract bool CanAddPlace { get; }
        public abstract bool CanAddTickets { get; }
    }
}
