using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketsServise
{
    public partial class Tickets : Form
    {
        Guid eventId = Guid.Empty;
        private Dictionary<Guid, Ticket> _tickets = new Dictionary<Guid, Ticket>();
        private Dictionary<Guid, Ticket> _cart = new Dictionary<Guid, Ticket>();
        private BindingSource _ticketsSrc = new BindingSource();
        public Tickets(Guid id)
        {
            InitializeComponent();
            eventId = id;
            LoadTickets();
        }
        private void LoadTickets()
        {
            if (eventId != Guid.Empty)
            {
                try
                {
                    var query = "SELECT available_tickets(@event_id);";
                    var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("@event_id", eventId)
                    };
                    DataTable availableTickets = DatabaseHelper.ExecuteQuery(query, parameters);
                    foreach (DataRow row in availableTickets.Rows)
                    {
                        Guid id = row.Field<Guid>("id");
                        string place = row.Field<string>("place");
                        decimal price = row.Field<decimal>("price");
                        Ticket ticket = new Ticket(id, place, price);
                        _tickets.Add(ticket.id, ticket);
                    }
                    _ticketsSrc.DataSource = _tickets;
                    ticketsList.DataSource = _ticketsSrc;
                    ticketsList.DisplayMember = "ToString";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить билеты.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID мероприятия пуст, невозможно загрузить билеты.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTicketBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
