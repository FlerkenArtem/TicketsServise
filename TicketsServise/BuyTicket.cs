using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace TicketsServise
{
    public partial class BuyTicket : Form
    {
        private Guid BuyerId = Guid.Empty;
        private List<Ticket> _tickets = new List<Ticket>();
        public BuyTicket(List<Ticket> tickets, Guid buyer)
        {
            BuyerId = buyer;
            foreach (Ticket ticket in tickets)
            {

            }
            InitializeComponent();
        }
        private byte[] GenDocument(Ticket ticket)
        {
            byte[] doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                    .Text("Билет на мероприятие: ")
                })
            }).GeneratePdf();
            return doc;
        }
    }
}
