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
        Guid EventId = Guid.Empty;
        Guid BuyerId = Guid.Empty;
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Ticket> _cart = new List<Ticket>();
        private BindingSource _ticketsSrc = new BindingSource();
        private BindingSource _cartSrc = new BindingSource();
        public Tickets(Guid eventId, Guid buyerId)
        {
            InitializeComponent();
            EventId = eventId;
            BuyerId = buyerId;
            LoadTickets();

            // Привязка данных билетов к ListBox
            _ticketsSrc.DataSource = _tickets;
            ticketsList.DataSource = _ticketsSrc;
            ticketsList.DisplayMember = "ToString";

            // Привязка данных корзины к ListBox 
            _cartSrc.DataSource = _cart;
            cartList.DataSource = _cartSrc;
            cartList.DisplayMember = "ToString";
        }
        private void LoadTickets()
        {
            if (EventId != Guid.Empty)
            {
                try
                {
                    var query = "SELECT available_tickets(@event_id);";
                    var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("@event_id", EventId)
                    };
                    DataTable availableTickets = DatabaseHelper.ExecuteQuery(query, parameters);
                    foreach (DataRow row in availableTickets.Rows)
                    {
                        Guid id = row.Field<Guid>("id");
                        string? place = row.Field<string>("place");
                        decimal price = row.Field<decimal>("price");
                        Ticket ticket = new Ticket(id, place, price);
                        _tickets.Add(ticket);
                        _ticketsSrc.ResetBindings(false);
                    }
                    
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
        private decimal CountCartSum() // Счет суммы корзины
        {
            decimal sum = 0;
            foreach(Ticket ticket in _cart)
            {
                sum += ticket.price;
            }
            return sum;
        }
        private void addTicketBtn_Click(object sender, EventArgs e)
        {
            if (ticketsList.SelectedItem is Ticket ticket)
            {
                _cart.Add(ticket);
                _tickets.Remove(ticket);
                _ticketsSrc.ResetBindings(false);
                _cartSrc.ResetBindings(false);
                sumLabel.Text = $"Сумма: {CountCartSum} рублей";
            }
            else
            {
                MessageBox.Show("Не выбран билет для добавления в корзину.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                sumLabel.Text = $"Сумма: {CountCartSum} рублей";
            }
            else
            {
                MessageBox.Show("Не выбран билет для удаления из корзины.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (_cart == null || _cart.Count == 0)
            {
                MessageBox.Show("Корзина пуста. Для перехода к покупке, добавьте билеты в корзину.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BuyerId == Guid.Empty)
            {
                MessageBox.Show("ID покупателя не задан.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BuyTicket buyTicket = new BuyTicket(_cart, BuyerId);
                buyTicket.ShowDialog();
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
