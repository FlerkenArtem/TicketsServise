using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class BuyerState : UserState
    {
        private readonly Guid _userId;
        public BuyerState(Guid userId) => _userId = userId;

        public override void Enter()
        {
            _context.logoutTool.Enabled = true;
            _context.organizerMenu.Visible = false;
            _context.buyBtn.Enabled = true;
            _context.loginTool.Visible = false;
            _context.buyerRegTool.Visible = false;
            _context.organizerRegTool.Visible = false;
        }
        public override void Exit() { }
        public override bool CanBuyTickets => true;
        public override bool CanCreateEvent => false;
        public override bool CanAddPlace => false;
        public override bool CanAddTickets => false;
    }
}
