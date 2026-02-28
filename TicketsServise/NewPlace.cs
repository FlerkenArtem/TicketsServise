using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class NewPlace : Form
    {
        private List<string> _regions;
        private List<string> _districts;
        private List<string> _cities;
        private List<string> _areas;
        private List<string> _streets;
        private List<string> _houses;
        private List<string> _flats;
        public NewPlace()
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
        private void LoadRegions()
        {
            regionComboBox.Items.Clear();
            try
            {
                var query = "SELECT name FROM region;";
                DataTable regions = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in regions.Rows)
                {
                    string name = row.Field<string>("name");
                    _regions.Add(name);
                }
                regionComboBox.DataSource = _regions;
                regionComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки регионов: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDistricts()
        {
            districtComboBox.Items.Clear();
            try
            {
                var query = "SELECT name FROM district;";
                DataTable districts = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in districts.Rows)
                {
                    string name = row.Field<string>("name");
                    _districts.Add(name);
                }
                districtComboBox.DataSource = _districts;
                districtComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки муниципальных районов: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCities()
        {
            cityComboBox.Items.Clear();
            try
            {
                var query = "SELECT name FROM city;";
                DataTable cities = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in cities.Rows)
                {
                    string name = row.Field<string>("name");
                    _cities.Add(name);
                }
                cityComboBox.DataSource = _cities;
                cityComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки городов: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAreas()
        {
            areaComboBox.Items.Clear();
            try
            {
                var query = "SELECT name FROM area;";
                DataTable areas = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in areas.Rows)
                {
                    string name = row.Field<string>("name");
                    _areas.Add(name);
                }
                areaComboBox.DataSource = _areas;
                areaComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки внутригородовых районов: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStreets()
        {
            streetComboBox.Items.Clear();
            try
            {
                var query = "SELECT name FROM street;";
                DataTable streets = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in streets.Rows)
                {
                    string name = row.Field<string>("name");
                    _streets.Add(name);
                }
                streetComboBox.DataSource = _streets;
                streetComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки улиц: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHouses()
        {
            houseComboBox.Items.Clear();
            try
            {
                var query = "SELECT number FROM house;";
                DataTable houses = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in houses.Rows)
                {
                    string number = row.Field<string>("number");
                    _houses.Add(number);
                }
                houseComboBox.DataSource = _houses;
                houseComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки домов: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadFlats()
        {
            flatComboBox.Items.Clear();
            try
            {
                var query = "SELECT number FROM flat;";
                DataTable flats = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in flats.Rows)
                {
                    string number = row.Field<string>("number");
                    _flats.Add(number);
                }
                flatComboBox.DataSource = _flats;
                flatComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки квартир: {ex}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void regionComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]*(?:[-\\s][А-Яа-яё]+)*$");
            if (regex.IsMatch(regionComboBox.Text))
            {
                regionComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                regionComboBox.BackColor = Color.DarkRed;
            }
        }
        private void districtComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]*(?:[-\\s][А-Яа-яё]+)*$");
            if (regex.IsMatch(districtComboBox.Text))
            {
                districtComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                districtComboBox.BackColor = Color.DarkRed;
            }
        }
        private void cityComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]*(?:[-\\s][А-Яа-яё]+)*$");
            if (regex.IsMatch(cityComboBox.Text))
            {
                cityComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                cityComboBox.BackColor = Color.DarkRed;
            }
        }
        private void areaComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]*(?:[-\\s][А-Яа-яё]+)*$");
            if (regex.IsMatch(areaComboBox.Text))
            {
                areaComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                areaComboBox.BackColor = Color.DarkRed;
            }
        }
        private void streetComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[А-ЯЁ][а-яё]*(?:[-\\s][А-Яа-яё]+)*$");
            if (regex.IsMatch(streetComboBox.Text))
            {
                streetComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                streetComboBox.BackColor = Color.DarkRed;
            }
        }
        private void houseComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^\\d+[А-ЯЁа-яё\\d\\-/]*(?:\\s+(?:корпус|к\\.|литера|лит\\.|строение|стр\\.|владение|влад\\.|сооружение|соор\\.|дом|д\\.)\\s*[А-ЯЁа-яё\\d]+|\\s+[А-ЯЁа-яё])*$");
            if (regex.IsMatch(houseComboBox.Text))
            {
                houseComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                houseComboBox.BackColor = Color.DarkRed;
            }
        }
        private void flatComboBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^\\d{1,4}[А-ЯЁа-яё]?$");
            if (regex.IsMatch(flatComboBox.Text))
            {
                flatComboBox.BackColor = Color.LightGreen;
            }
            else
            {
                flatComboBox.BackColor = Color.DarkRed;
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string region = regionComboBox.Text;
            string? district = districtComboBox.Text;
            string city = cityComboBox.Text;
            string? area = areaComboBox.Text;
            string street = streetComboBox.Text;
            string house = houseComboBox.Text;
            string? flat = flatComboBox.Text;
            string index = indexTextBox.Text;
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(city) ||
                string.IsNullOrEmpty(street) ||
                string.IsNullOrEmpty(house) ||
                string.IsNullOrEmpty(index))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var query = "CALL new_place(@name, @region, @district, @city, @area, @street, @house, @flat, @index);";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@name", name),
                    new NpgsqlParameter("@region", region),
                    new NpgsqlParameter("@district", district),
                    new NpgsqlParameter("@city", city),
                    new NpgsqlParameter("@area", area),
                    new NpgsqlParameter("@street", street),
                    new NpgsqlParameter("@house", house),
                    new NpgsqlParameter("@flat", flat),
                    new NpgsqlParameter("@index", index)
                };
                var res = DatabaseHelper.ExecuteScalar(query, parameters);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
