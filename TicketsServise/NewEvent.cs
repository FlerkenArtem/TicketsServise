using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class NewEvent : Form
    {
        private Guid organizerId;
        private Dictionary<string, string?> _performers = new Dictionary<string, string?>();
        private BindingSource _performersSrc = new BindingSource();
        private Dictionary<Guid, string> _places = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _types = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _genres = new Dictionary<Guid, string>();
        private DateTime eventDateTime;
        public NewEvent(Guid id)
        {
            this.organizerId = id;
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
        private void LoadPlaces() // Загрузка площадок
        {
            try
            {
                _places.Clear();
                var query = "SELECT id, name FROM place";
                DataTable placesData = DatabaseHelper.ExecuteQuery(query);

                if (placesData.Rows.Count == 0)
                {
                    MessageBox.Show("В базе данных нет ни одной площадки.\nСначала создайте площадку через меню организатора.",
                        "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataRow row in placesData.Rows)
                {
                    _places.Add(row.Field<Guid>("id"), row.Field<string>("name"));
                }

                placeComboBox.DataSource = _places.ToList();
                placeComboBox.DisplayMember = "Value";
                placeComboBox.ValueMember = "Key";
                placeComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить площадки из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTypes() // Загрузить типы мероприятий
        {
            try
            {
                _types.Clear();
                var query = "SELECT id, type FROM event_type";
                DataTable typesData = DatabaseHelper.ExecuteQuery(query);

                if (typesData.Rows.Count == 0)
                {
                    MessageBox.Show("В базе данных нет типов мероприятий.\nОбратитесь к администратору.",
                        "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataRow row in typesData.Rows)
                {
                    _types.Add(row.Field<Guid>("id"), row.Field<string>("type"));
                }

                typeComboBox.DataSource = _types.ToList();
                typeComboBox.DisplayMember = "Value";
                typeComboBox.ValueMember = "Key";
                typeComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить типы мероприятий из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGenres() // Загрузить жанры
        {
            try
            {
                _genres.Clear();
                var query = "SELECT id, genre FROM event_genre";
                DataTable genresData = DatabaseHelper.ExecuteQuery(query);

                if (genresData.Rows.Count == 0)
                {
                    MessageBox.Show("В базе данных нет жанров мероприятий.\nОбратитесь к администратору.",
                        "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataRow row in genresData.Rows)
                {
                    _genres.Add(row.Field<Guid>("id"), row.Field<string>("genre"));
                }

                genreComboBox.DataSource = _genres.ToList();
                genreComboBox.DisplayMember = "Value";
                genreComboBox.ValueMember = "Key";
                genreComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить жанры мероприятий из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string query = @"CALL new_event(
                                @organizer::uuid,
                                @name::varchar,
                                @datetime::timestamp,
                                @place::uuid,
                                @type::uuid,
                                @genre::uuid,
                                @performers::varchar[],
                                @performers_info::text[])";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id", organizerId),
                    new NpgsqlParameter("@name", name),
                    new NpgsqlParameter("@datetime", dateTime),
                    new NpgsqlParameter("@place_id", placeId),
                    new NpgsqlParameter("@type_id", typeId),
                    new NpgsqlParameter("@genre_id", genreId),
                    new NpgsqlParameter("@performers_array", performers),
                    new NpgsqlParameter("@performers_info_array", performersInfo)
                };
                var res = DatabaseHelper.ExecuteNonQuery(query, parameters);
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
