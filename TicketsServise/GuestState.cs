namespace TicketsServise
{
    public class GuestState : UserState
    {
        public override void Enter()
        {
            _context.logoutTool.Enabled = false;
            _context.organizerMenu.Visible = false;
            _context.buyBtn.Enabled = false;
            _context.loginTool.Visible = true;
            _context.buyerRegTool.Visible = true;
            _context.organizerRegTool.Visible = true;
        }
        public override void Exit() { }
        public override bool CanBuyTickets => false;
        public override bool CanCreateEvent => false;
        public override bool CanAddPlace => false;
        public override bool CanAddTickets => false;
    }
}
