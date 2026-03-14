using Npgsql;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data;

namespace TicketsServise
{
    public partial class BuyTicket : Form
    {
        private Guid BuyerId = Guid.Empty;
        private List<Ticket> _tickets = new List<Ticket>();
        private Dictionary<Guid, string> _paymentTypes = new Dictionary<Guid, string>();
        private BindingSource _paymentTypesSrc = new BindingSource();
        private List<byte[]> _documents = new List<byte[]>();
        private readonly IDatabase _db;
        private TicketDoc _ticketDoc;
        public BuyTicket(IDatabase db, List<Ticket> tickets, Guid buyer)
        {
            InitializeComponent();
            _db = db;
            BuyerId = buyer;
            _tickets = tickets;
            LoadPaymentTypes();
            _paymentTypesSrc.DataSource = _paymentTypes.ToList();
            paymentTypeComboBox.DataSource = _paymentTypesSrc;
            paymentTypeComboBox.DisplayMember = "Value";
            paymentTypeComboBox.ValueMember = "Key";
            paymentTypeComboBox.SelectedIndex = -1;
        }
        private void LoadPaymentTypes()
        {
            try
            {
                var query = "SELECT * FROM payment_type;";
                DataTable dt = _db.ExecuteQuery(query);
                _paymentTypes.Clear();
                paymentTypeComboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Guid id = row.Field<Guid>("id");
                    string type = row.Field<string>("type");
                    _paymentTypes.Add(id, type);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            _documents.Clear();
            foreach (Ticket ticket in _tickets)
            {
                try
                {
                    var query = "SELECT * FROM event_data_for_ticket(@ticket_id);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@ticket_id", ticket.id)
                    };
                    DataTable dt = _db.ExecuteQuery(query, parameters);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"Не удалось получить данные мероприятия для билета {ticket.place}.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow row = dt.Rows[0];
                    Guid eId = row.Field<Guid>("e_id");
                    string name = row.Field<string>("event_name");
                    string organizer = row.Field<string>("organizer_name");
                    DateTime dateTime = row.Field<DateTime>("date_time");
                    string place = row.Field<string>("place_name");

                    Event ev = new Event(eId, name, organizer, dateTime, place);
                    byte[] doc = _ticketDoc.Generate(ticket, ev);
                    _documents.Add(doc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка генерации билета: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (_documents.Count != _tickets.Count)
            {
                MessageBox.Show("Не удалось сформировать все билеты.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Guid paymentTypeId = (Guid)paymentTypeComboBox.SelectedValue;
                bool isCardPayment = paymentTypeId == new Guid("019c2ec6-9c46-7f96-b45b-90575b8f41cc");
                var ticketIds = _tickets.Select(t => t.id).ToArray();
                var parameters = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@tickets", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Uuid)
                        { Value = ticketIds },
                    new NpgsqlParameter("@buyer", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = BuyerId },
                    new NpgsqlParameter("@files", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Bytea)
                        { Value = _documents.ToArray() },
                    new NpgsqlParameter("@payment_type", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = paymentTypeId }
                };
                string query;
                if (isCardPayment)
                {
                    query = "CALL buying(@tickets, @buyer, @files, @payment_type, @card_number, @valid_thru, @cvv2)";
                    parameters.AddRange(new[]
                    {
                        new NpgsqlParameter("@card_number", NpgsqlTypes.NpgsqlDbType.Char)
                            { Value = string.IsNullOrWhiteSpace(cardNumberTextBox.Text) ? DBNull.Value : cardNumberTextBox.Text },
                        new NpgsqlParameter("@valid_thru", NpgsqlTypes.NpgsqlDbType.Char)
                            { Value = string.IsNullOrWhiteSpace(validThruTextBox.Text) ? DBNull.Value : validThruTextBox.Text },
                        new NpgsqlParameter("@cvv2", NpgsqlTypes.NpgsqlDbType.Char)
                            { Value = string.IsNullOrWhiteSpace(cvv2TextBox.Text) ? DBNull.Value : cvv2TextBox.Text }
                    });
                }
                else
                {
                    query = "CALL buying(@tickets, @buyer, @files, @payment_type)";
                }
                _db.ExecuteNonQuery(query, parameters.ToArray());
                MessageBox.Show("Покупка успешно завершена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (PostgresException ex)
            {
                MessageBox.Show($"Ошибка БД: {ex.MessageText}\n{ex.Detail}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void paymentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentTypeComboBox.SelectedValue is Guid selectedId)
            {
                Guid cardGuid = new Guid("019c2ec6-9c46-7f96-b45b-90575b8f41cc");
                bool isCard = selectedId == cardGuid;
                cardGroupBox.Enabled = isCard;
                cardGroupBox.Visible = isCard;
            }
        }
    }
}
