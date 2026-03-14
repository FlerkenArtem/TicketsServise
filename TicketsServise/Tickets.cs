using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TicketsServise
{
    public partial class Tickets : Form
    {
        private Guid EventId;
        private Guid BuyerId;
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Ticket> _cart = new List<Ticket>();
        private BindingSource _ticketsSrc = new BindingSource();
        private BindingSource _cartSrc = new BindingSource();
        private readonly IDatabase _db;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IPriceCalculator PriceCalculator { get; set; } = new SumCalculator();
        public Tickets(IDatabase db ,Guid eventId, Guid buyerId)
        {
            InitializeComponent();
            _db = db;
            EventId = eventId;
            BuyerId = buyerId;
            LoadTickets();

            _ticketsSrc.DataSource = _tickets;
            ticketsList.DataSource = _ticketsSrc;
            ticketsList.DisplayMember = "ToString";

            _cartSrc.DataSource = _cart;
            cartList.DataSource = _cartSrc;
            cartList.DisplayMember = "ToString";

            UpdateSumLabel();
        }

        private void LoadTickets()
        {
            if (EventId == Guid.Empty)
            {
                MessageBox.Show("ID мероприятия пуст.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var query = "SELECT * FROM available_tickets(@event_id)";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@event_id", EventId)
                };
                DataTable data = _db.ExecuteQuery(query, parameters);

                _tickets.Clear();
                foreach (DataRow row in data.Rows)
                {
                    _tickets.Add(new Ticket(
                        row.Field<Guid>("ticket_id"),
                        row.Field<string>("place"),
                        row.Field<decimal>("price")
                    ));
                }
                _ticketsSrc.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки билетов: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CountCartSum()
        {
            return PriceCalculator.Calculate(_cart);
        }

        private void UpdateSumLabel()
        {
            sumLabel.Text = $"Сумма: {CountCartSum():F2} рублей";
        }

        private void addTicketBtn_Click(object sender, EventArgs e)
        {
            if (ticketsList.SelectedItem is Ticket ticket)
            {
                _cart.Add(ticket);
                _tickets.Remove(ticket);
                _ticketsSrc.ResetBindings(false);
                _cartSrc.ResetBindings(false);
                UpdateSumLabel();
            }
            else
            {
                MessageBox.Show("Выберите билет для добавления.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delTicketBtn_Click(object sender, EventArgs e)
        {
            if (cartList.SelectedItem is Ticket ticket)
            {
                _cart.Remove(ticket);
                _tickets.Add(ticket);
                _ticketsSrc.ResetBindings(false);
                _cartSrc.ResetBindings(false);
                UpdateSumLabel();
            }
            else
            {
                MessageBox.Show("Выберите билет для удаления.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Корзина пуста.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BuyerId == Guid.Empty)
            {
                MessageBox.Show("ID покупателя не задан.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var buyForm = new BuyTicket(_db, _cart, BuyerId);
            buyForm.ShowDialog();
            LoadTickets();
            _cart.Clear();
            _cartSrc.ResetBindings(false);
            UpdateSumLabel();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}