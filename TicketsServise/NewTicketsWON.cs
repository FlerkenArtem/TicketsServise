using Npgsql;
using System.Data;

namespace TicketsServise
{
    public partial class NewTicketsWON : Form
    {
        private Guid organizerId;
        private Dictionary<Guid, string> _events;
        public NewTicketsWON(Guid id)
        {
            InitializeComponent();
            organizerId = id;
            LoadEvents();
        }
        private void LoadEvents()
        {
            if (organizerId == Guid.Empty)
            {
                MessageBox.Show("Не удалось получить ID организатора.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            else
            {
                eventComboBox.Items.Clear();
                try
                {
                    var query = @"SELECT id, name 
                                FROM event 
                                WHERE organizer = @organizer_id;";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@organizer_id", organizerId)
                    };
                    DataTable events = DatabaseHelper.ExecuteQuery(query, parameters);
                    foreach (DataRow row in events.Rows)
                    {
                        Guid id = row.Field<Guid>("id");
                        string name = row.Field<string>("name");
                        _events.Add(id, name);
                    }
                    eventComboBox.DataSource = _events;
                    eventComboBox.SelectedIndex = -1;
                    eventComboBox.DisplayMember = "Value";
                    eventComboBox.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить мероприятия из БД: {ex}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void countEdit_ValueChanged(object sender, EventArgs e)
        {
            if (countEdit.Value > 0)
            {
                countEdit.BackColor = Color.LightGreen;
            }
            else
            {
                countEdit.BackColor = Color.DarkRed;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Guid eventId = Guid.Empty;
            if (Guid.TryParse(eventComboBox.SelectedValue.ToString(), out Guid id))
            {
                eventId = id;
            }
            else
            {
                eventId = Guid.Empty;
            }
            decimal price = priceEdit.Value;
            int ticketsCount = (int)countEdit.Value;
            string placeName = placeNameEdit.Text;
            if (eventId == Guid.Empty ||
                price <= 0 || 
                ticketsCount <= 0 || 
                string.IsNullOrEmpty(placeName))
            {
                MessageBox.Show("Не все необходимые поля заполнены или поля заполнены неверно.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    var query = $"CALL new_tickets_wo_num(@event_id, @price, @count, @place);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@event_id", eventId),
                        new NpgsqlParameter("@price", price),
                        new NpgsqlParameter("@count", ticketsCount),
                        new NpgsqlParameter("@place", placeName)
                    };
                    var res = DatabaseHelper.ExecuteScalar(query, parameters);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
