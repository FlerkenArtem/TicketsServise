using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class OrganizerState : UserState
    {
        private readonly Guid _userId;
        public OrganizerState(Guid userId) => _userId = userId;

        public override void Enter()
        {
            _context.logoutTool.Enabled = true;
            _context.organizerMenu.Visible = true;
            _context.buyBtn.Enabled = false;
            _context.loginTool.Visible = false;
            _context.buyerRegTool.Visible = false;
            _context.organizerRegTool.Visible = false;
        }
        public override void Exit() { }
        public override bool CanBuyTickets => false;
        public override bool CanCreateEvent => true;
        public override bool CanAddPlace => true;
        public override bool CanAddTickets => true;
    }
}
