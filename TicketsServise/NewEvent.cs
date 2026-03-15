using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class NewEvent : BaseForm
    {
        private Guid organizerId;
        private Dictionary<string, string?> _performers = new Dictionary<string, string?>();
        private BindingSource _performersSrc = new BindingSource();
        private Dictionary<Guid, string> _places = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _types = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _genres = new Dictionary<Guid, string>();
        private DateTime eventDateTime;
        public NewEvent(IDatabase db, Guid id) : base(db)
        {
            organizerId = id;
            InitializeComponent();
            _performersSrc.DataSource = _performers.Keys.ToList();
            performersListBox.DataSource = _performersSrc;
            LoadPlaces();
            LoadTypes();
            LoadGenres();
        }
        private void dateTimeTextBox_TextChanged(object sender, EventArgs e) // Прорверка Формата даты и времени
        {
            Regex regex = new Regex(@"^(?:(?:(?:0[1-9]|1[0-9]|2[0-8])[./](?:0[1-9]|1[0-2])|(?:29|30)[./](?:0[13-9]|1[0-2])|31[./](?:0[13578]|1[02]))[./](?:[0-9]{4})|29[./]02[./](?:(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26]))|(?:[02468][048]|[13579][26])00)) (0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"); if (regex.IsMatch(dateTimeTextBox.Text))
            {
                if (DateTime.TryParse(dateTimeTextBox.Text, out DateTime dateTime))
                {
                    if (dateTime > DateTime.Today.AddDays(1))
                    {
                        dateTimeTextBox.BackColor = Color.LightGreen;
                        eventDateTime = dateTime;
                    }
                    else
                    {
                        dateTimeTextBox.BackColor = Color.DarkRed;
                    }
                }
                else
                {
                    dateTimeTextBox.BackColor = Color.DarkRed;
                }
            }
            else
            {
                dateTimeTextBox.BackColor = Color.DarkRed;
            }
        }
        private void LoadPlaces()
        {
            LoadDictionary<Guid>(placeComboBox, "SELECT id, name FROM place",
                row => row.Field<Guid>("id"),
                row => row.Field<string>("name"));
        }
        private void LoadTypes()
        {
            LoadDictionary<Guid>(typeComboBox, "SELECT id, type FROM event_type",
                row => row.Field<Guid>("id"),
                row => row.Field<string>("type"));
        }
        private void LoadGenres()
        {
            LoadDictionary<Guid>(genreComboBox, "SELECT id, genre FROM event_genre",
                row => row.Field<Guid>("id"),
                row => row.Field<string>("genre"));
        }
        private void addBtn_Click(object sender, EventArgs e) // Добавить исполнителя
        {
            string performerName = performerTextBox.Text.Trim();
            string performerInfo = performerInfoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(performerName))
            {
                MessageBox.Show("Введите имя исполнителя.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _performers[performerName] = performerInfo;

            _performersSrc.DataSource = _performers.Keys.ToList();
            _performersSrc.ResetBindings(false);

            performerTextBox.Clear();
            performerInfoTextBox.Clear();
        }
        private void delBtn_Click(object sender, EventArgs e) // Удалить исполниеля
        {
            if (performersListBox.SelectedItem != null)
            {
                string selected = performersListBox.SelectedItem.ToString();
                if (_performers.Remove(selected))
                {
                    _performersSrc.DataSource = _performers.Keys.ToList();
                    _performersSrc.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Выберите исполнителя для удаления.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void okBtn_Click(object sender, EventArgs e) // Запрос к БД
        {
            Guid guid = organizerId;
            string name = nameTextBox.Text;
            DateTime dateTime = eventDateTime;
            if (!(placeComboBox.SelectedValue is Guid placeId))
            {
                MessageBox.Show("Не выбрана площадка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(typeComboBox.SelectedValue is Guid typeId))
            {
                MessageBox.Show("Не выбран тип мероприятия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(genreComboBox.SelectedValue is Guid genreId))
            {
                MessageBox.Show("Не выбран жанр мероприятия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] performers = _performers.Keys.ToArray();
            string?[] performersInfo = _performers.Values.ToArray();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query = @"CALL public.new_event(
                            @organizer,
                            @name,
                            @datetime,
                            @place,
                            @type,
                            @genre,
                            @performers,
                            @performers_info)";

                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("organizer", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = guid },
                    new NpgsqlParameter("name", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = name },
                    new NpgsqlParameter("datetime", NpgsqlTypes.NpgsqlDbType.Timestamp) { Value = dateTime },
                    new NpgsqlParameter("place", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = placeId },
                    new NpgsqlParameter("type", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = typeId },
                    new NpgsqlParameter("genre", NpgsqlTypes.NpgsqlDbType.Uuid) { Value = genreId },
                    new NpgsqlParameter("performers", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Varchar) { Value = performers },
                    new NpgsqlParameter("performers_info", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Text) { Value = performersInfo }
                };

                _db.ExecuteNonQuery(query, parameters);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e) // Закрыть окно
        {
            Close();
        }
    }
}
