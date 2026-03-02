using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketsServise
{
    public partial class BuyTicket : Form
    {
        Guid ticketId = Guid.Empty;
        Guid buyerId = Guid.Empty;
        public BuyTicket(Guid ticket, Guid buyer)
        {
            this.ticketId = ticket;
            this.buyerId = buyer;
            InitializeComponent();
        }
    }
}
