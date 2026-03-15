using Npgsql;
using System.Data;

namespace TicketsServise
{
    public partial class NewPlace : BaseForm
    {
        public NewPlace(IDatabase db) : base(db)
        {
            InitializeComponent();
            LoadRegions();
            LoadDistricts();
            LoadCities();
            LoadAreas();
            LoadStreets();
            LoadHouses();
            LoadFlats();
        }
        private void LoadRegions() => LoadList("SELECT name FROM region ORDER BY name;", regionComboBox);
        private void LoadDistricts() => LoadList("SELECT name FROM district ORDER BY name;", districtComboBox);
        private void LoadCities() => LoadList("SELECT name FROM city ORDER BY name;", cityComboBox);
        private void LoadAreas() => LoadList("SELECT name FROM area ORDER BY name;", areaComboBox);
        private void LoadStreets() => LoadList("SELECT name FROM street ORDER BY name;", streetComboBox);
        private void LoadHouses() => LoadList("SELECT number FROM house ORDER BY number;", houseComboBox);
        private void LoadFlats() => LoadList("SELECT number FROM flat ORDER BY number;", flatComboBox);

        private void LoadList(string query, ComboBox comboBox)
        {
            var dataTable = ExecuteQuery(query);
            var items = new List<string>();
            foreach (DataRow row in dataTable.Rows)
                items.Add(row[0].ToString());
            comboBox.DataSource = items;
            comboBox.SelectedIndex = -1;
        }

        // Валидация полей с помощью ValidationHelper
        private void regionComboBox_TextChanged(object sender, EventArgs e)
        {
            regionComboBox.BackColor = ValidationHelper.IsValidRegion(regionComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void districtComboBox_TextChanged(object sender, EventArgs e)
        {
            districtComboBox.BackColor = ValidationHelper.IsValidOptional(districtComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void cityComboBox_TextChanged(object sender, EventArgs e)
        {
            cityComboBox.BackColor = ValidationHelper.IsValidRegion(cityComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void areaComboBox_TextChanged(object sender, EventArgs e)
        {
            areaComboBox.BackColor = ValidationHelper.IsValidOptional(areaComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void streetComboBox_TextChanged(object sender, EventArgs e)
        {
            streetComboBox.BackColor = ValidationHelper.IsValidRegion(streetComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void houseComboBox_TextChanged(object sender, EventArgs e)
        {
            houseComboBox.BackColor = ValidationHelper.IsValidHouse(houseComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void flatComboBox_TextChanged(object sender, EventArgs e)
        {
            flatComboBox.BackColor = ValidationHelper.IsValidFlat(flatComboBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        // Кнопка "ОК"
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string region = regionComboBox.Text.Trim();
            string district = districtComboBox.Text.Trim();
            string city = cityComboBox.Text.Trim();
            string area = areaComboBox.Text.Trim();
            string street = streetComboBox.Text.Trim();
            string house = houseComboBox.Text.Trim();
            string flat = flatComboBox.Text.Trim();
            string index = indexTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(city) || string.IsNullOrEmpty(street) ||
                string.IsNullOrEmpty(house) || string.IsNullOrEmpty(index))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = @"CALL new_place(
                            @name::varchar, @region::varchar, @district::varchar,
                            @city::varchar, @area::varchar, @street::varchar,
                            @house::varchar, @flat::varchar, @index::varchar);";

                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@name", name),
                    new NpgsqlParameter("@region", region),
                    new NpgsqlParameter("@district", string.IsNullOrEmpty(district) ? DBNull.Value : (object)district),
                    new NpgsqlParameter("@city", city),
                    new NpgsqlParameter("@area", string.IsNullOrEmpty(area) ? DBNull.Value : (object)area),
                    new NpgsqlParameter("@street", street),
                    new NpgsqlParameter("@house", house),
                    new NpgsqlParameter("@flat", string.IsNullOrEmpty(flat) ? DBNull.Value : (object)flat),
                    new NpgsqlParameter("@index", index)
                };

                ExecuteNonQuery(query, parameters);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) => Close();
    }
}