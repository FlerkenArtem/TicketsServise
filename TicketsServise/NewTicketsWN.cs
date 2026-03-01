using Npgsql;
using System.Data;

namespace TicketsServise
{
    public partial class NewTicketsWN : Form
    {
        Guid organizerId = Guid.Empty;
        private Dictionary<Guid, string> _events;
        public NewTicketsWN(Guid id)
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
        private void placeEdits_ValueChanged(object sender, EventArgs e)
        {
            if (placeFromEdit.Value > placeToEdit.Value)
            {
                placeFromEdit.BackColor = Color.DarkRed;
                placeToEdit.BackColor = Color.DarkRed;
            }
            else
            {
                placeFromEdit.BackColor = Color.LightGreen;
                placeToEdit.BackColor = Color.LightGreen;
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            Guid eventId = eventComboBox.SelectedIndex.Key();
            decimal price = priceEdit.Value;
            int placeFrom = placeFromEdit.Value;
            int placeTo = placeToEdit.Value;
            if (eventId == Guid.Empty ||
                price == null ||
                price <= 0 ||
                placeFrom > placeTo ||
                placeFrom <= 0 ||
                placeFrom == null ||
                placeTo == null)
            {
                MessageBox.Show("Не все необходимые поля заполнены или поля заполнены неверно.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    var query = @"CALL new_tickets_with_num(@event_id, @price, @place_from, @place_to);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@event_id", eventId),
                        new NpgsqlParameter("@price", price),
                        new NpgsqlParameter("@place_from", placeFrom),
                        new NpgsqlParameter("@place_to", placeTo)
                    };
                    var res = DatabaseHelper.ExecuteScalar(query, parameters)
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