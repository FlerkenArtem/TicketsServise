using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TicketsServise
{
    public partial class NewEvent : Form
    {
        private Guid organizerId;
        private Dictionary<string, string?> _performers;
        private BindingSource _performersSrc;
        private Dictionary<Guid, string> _places;
        private Dictionary<Guid, string> _types;
        private Dictionary<Guid, string> _genres;
        private DateTime eventDateTime;
        public NewEvent(Guid id)
        {
            this.organizerId = id;
            _performersSrc.DataSource = _performers.Keys.ToList();
            performersListBox.DataSource = _performersSrc;
            InitializeComponent();
            LoadPlaces();
            LoadTypes();
            LoadGenres();
        }
        private void dateTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^(?:(?:(?:0[1-9]|1[0-9]|2[0-8])/(?:0[1-9]|1[0-2])|(?:29|30)/(?:0[13-9]|1[0-2])|31/(?:0[13578]|1[02]))/(?:[0-9]{4})|29/02/(?:(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26]))|(?:[02468][048]|[13579][26])00)) (0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (regex.IsMatch(dateTimeTextBox.Text))
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
            try
            {
                var query = "SELECT id, name FROM place";
                DataTable placesData = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in placesData.Rows)
                {
                    Guid id = row.Field<Guid>("id");
                    string name = row.Field<string>("name");
                    _places.Add(id, name);
                }
                placeComboBox.DataSource = _places;
                placeComboBox.DisplayMember = "Value";
                placeComboBox.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить площадки из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTypes()
        {
            try
            {
                var query = "SELECT id, type FROM event_type";
                DataTable typesData = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in typesData.Rows)
                {
                    Guid id = row.Field<Guid>("id");
                    string type = row.Field<string>("type");
                    _types.Add(id, type);
                }
                typeComboBox.DataSource = _types;
                typeComboBox.DisplayMember = "Value";
                typeComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить типы мероприятий из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGenres()
        {
            try
            {
                var query = "SELECT id, genre FROM event_genre";
                DataTable genresData = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in genresData.Rows)
                {
                    Guid id = row.Field<Guid>("id");
                    string genre = row.Field<string>("genre");
                    _genres.Add(id, genre);
                }
                genreComboBox.DataSource = _genres;
                genreComboBox.DisplayMember = "Value";
                genreComboBox.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить жанры мероприятий из БД: {ex}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string? performerName = null;
            string? performerInfo = null;
            if (string.IsNullOrEmpty(performerTextBox.Text))
            {
                performerName = performerTextBox.Text;
            }
            if (string.IsNullOrEmpty(performerInfoTextBox.Text))
            {
                performerInfo = performerInfoTextBox.Text;
            }
            else
            {
                performerInfo = "NULL";
            }
            if (!string.IsNullOrEmpty(performerName) && !string.IsNullOrEmpty(performerInfo))
            {
                _performers.Add(performerName, performerInfo);
                _performersSrc.ResetBindings(false);
                performerTextBox.Clear();
                performerInfoTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Заполните имя исполнителя.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (performersListBox.SelectedItem != null && performersListBox.SelectedItem.ToString() is string selected)
            {
                if (_performers.Remove(selected))
                {
                    _performersSrc.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить исполнителя.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не выбран исполнитель для удаления.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string strOrgId;
            if (organizerId != Guid.Empty)
            {
                strOrgId = organizerId.ToString();
            }
            else
            {
                MessageBox.Show("ID организатора пуст.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = nameTextBox.Text;
            string dateTime = eventDateTime.ToString("yyyy-MM-dd hh:mm:ss");
            string? placeId;
            string? typeId;
            string? genreId;
            if (placeComboBox.SelectedValue != null)
            {
                placeId = placeComboBox.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Не выбрана площадка.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (typeComboBox.SelectedValue != null)
            {
                typeId = typeComboBox.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Не выбран тип мероприятия.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (genreComboBox.SelectedValue != null)
            {
                genreId = genreComboBox.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Не выбран жанр мероприятия.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] performers = _performers.Keys.ToArray();
            string?[] performersInfo = _performers.Values.ToArray();
            if (string.IsNullOrEmpty(strOrgId) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(dateTime) ||
                string.IsNullOrEmpty(placeId) ||
                string.IsNullOrEmpty(typeId) ||
                string.IsNullOrEmpty(genreId))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var query = @"CALL new_event( 
                            @id, @name, @datetime, @place_id, @type_id, @genre_id, 
                            @performers_array, @performers_info_array);";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id", strOrgId),
                    new NpgsqlParameter("@name", name),
                    new NpgsqlParameter("@datetime", dateTime),
                    new NpgsqlParameter("@place_id", placeId),
                    new NpgsqlParameter("@type_id", typeId),
                    new NpgsqlParameter("@genre_id", genreId),
                    new NpgsqlParameter("@performers_array", performers),
                    new NpgsqlParameter("@performers_info_array", performersInfo)
                };
                var res = DatabaseHelper.ExecuteScalar(query, parameters);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
