using Microsoft.Extensions.Logging;
using Npgsql;
using System.Data;
using System.Numerics;

namespace TicketsServise
{
    public partial class MainWindow : Form
    {
        private Guid buyerId;
        private Guid organizerId;
        private Guid eventId;
        private List<EventsInfo> _events = new List<EventsInfo>();
        private List<TicketsInfo> _tickets = new List<TicketsInfo>();
        private Dictionary<Guid, string> _cityFilter = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _placeFilter = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _typeFilter = new Dictionary<Guid, string>();
        private Dictionary<Guid, string> _genreFilter = new Dictionary<Guid, string>();
        public MainWindow()
        {
            InitializeComponent();
            LoadCities();
            LoadPlaces();
            LoadTypes();
            LoadGenres();
            LoadEvents();
        }
        private void buyerRegTool_Click(object sender, EventArgs e)
        {
            BuyerReg buyerReg = new BuyerReg();
            buyerReg.RegEnd += (id) =>
                {
                    BuyerToolsLoad(id);
                };
            buyerReg.ShowDialog();
        }
        private void organizerRegTool_Click(object sender, EventArgs e)
        {
            OrganizerReg organizerReg = new OrganizerReg();
            organizerReg.ShowDialog();
            organizerReg.RegEnd += (id) =>
            {
                OrganizerToolsLoad(id);
            };
        }
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (buyerId == Guid.Empty && e.TabPageIndex == 1)
            {
                MessageBox.Show("Просмотр купленных билетов возможен только, если вы войдете в систему в роли покупателя. " +
                    "\n\nЧтобы войти в систему:" +
                    "\n1. Нажмите на кнопку \"Аккаунт\" в верхнем меню." +
                    "\n2. В меню выберите \"Войти\"." +
                    "\n3. Введите свой логин и пароль." +
                    "\n\nЕсли вы не зарегистрированы в системе:" +
                    "\n1. Нажмите на кнопку \"Аккаунт\" в верхнем меню." +
                    "\n2. В меню выберите \"Зарегистиророваться\"." +
                    "\n3. Далее в меню выберите \"Покупатель\"." +
                    "\n4. Введите свои данные для регистрации.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (buyerId != Guid.Empty && e.TabPageIndex == 1)
            {
                LoadTickets();
            }
            else if (e.TabPageIndex == 0)
            {
                LoadEvents();
            }
        }
        private void logoutTool_Click(object sender, EventArgs e)
        {
            buyerId = Guid.Empty;
            organizerId = Guid.Empty;
            organizerMenu.Enabled = false;
            organizerMenu.Visible = false;
            logoutTool.Enabled = false;
            buyBtn.Enabled = false;
            tabControl.TabIndex = 0;
            MessageBox.Show("Вы вышли из аккаунта",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void loginTool_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.AccountType += (type) =>
            {
                if (type == 1)
                {
                    login.LoginEnd += (id) =>
                    {
                        OrganizerToolsLoad(id);
                    };
                }
                else if (type == 0)
                {
                    login.LoginEnd += (id) =>
                    {
                        BuyerToolsLoad(id);
                    };
                }
            };
            login.ShowDialog();
        }
        private void OrganizerToolsLoad(Guid newId)
        {
            buyerId = Guid.Empty;
            organizerId = newId;
            logoutTool.Enabled = true;
            organizerMenu.Visible = true;
            organizerMenu.Enabled = true;
            loginTool.Visible = false;
            loginTool.Enabled = false;
            buyerRegTool.Visible = false;
            buyerRegTool.Enabled = false;
            organizerRegTool.Visible = false;
            organizerRegTool.Enabled = false;
        }
        private void BuyerToolsLoad(Guid newId)
        {
            organizerId = Guid.Empty;
            buyerId = newId;
            logoutTool.Enabled = true;
            buyBtn.Enabled = true;
            loginTool.Visible = false;
            loginTool.Enabled = false;
            buyerRegTool.Visible = false;
            buyerRegTool.Enabled = false;
            organizerRegTool.Visible = false;
            organizerRegTool.Enabled = false;
        }
        private void aboutTool_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void newEventTool_Click(object sender, EventArgs e)
        {
            if (organizerId != Guid.Empty)
            {
                NewEvent newEvent = new NewEvent(organizerId);
                newEvent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для добавления мероприятия необходимо войти в систему как организатор.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void newPlaceTool_Click(object sender, EventArgs e)
        {
            if (organizerId != Guid.Empty)
            {
                NewPlace newPlace = new NewPlace();
                newPlace.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для добавления площадки необходимо войти в систему как организатор.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ticketsWNTool_Click(object sender, EventArgs e)
        {
            if (organizerId == Guid.Empty)
            {
                MessageBox.Show("Для добавления билетов необходимо войти в систему как организатор.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                NewTicketsWN newTickets = new NewTicketsWN(organizerId);
                newTickets.ShowDialog();
            }
        }
        private void ticketsWONTool_Click(object sender, EventArgs e)
        {
            if (organizerId == Guid.Empty)
            {
                MessageBox.Show("Для добавления билетов необходимо войти в систему как организатор.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                NewTicketsWON newTickets = new NewTicketsWON(organizerId);
                newTickets.ShowDialog();
            }
        }
        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (buyerId == Guid.Empty || eventId == Guid.Empty)
            {
                MessageBox.Show("Для покупки билетов необходимо войти в систему как покупатель.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Tickets tickets = new Tickets(eventId, buyerId);
                tickets.ShowDialog();
            }
        }
        private void LoadCities()
        {
            var query = "SELECT id, name FROM city;";
            DataTable res = DatabaseHelper.ExecuteQuery(query);
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("В базе данных нет ни одного города.",
                        "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in res.Rows)
            {
                _cityFilter.Add(row.Field<Guid>("id"), row.Field<string>("name"));
            }
            cityComboBox.DataSource = _cityFilter.ToList();
            cityComboBox.SelectedIndex = -1;
            cityComboBox.ValueMember = "Key";
            cityComboBox.DisplayMember = "Value";

        }
        private void LoadPlaces() // Загрузка площадок
        {
            try
            {
                _placeFilter.Clear();
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
                    _placeFilter.Add(row.Field<Guid>("id"), row.Field<string>("name"));
                }

                placeComboBox.DataSource = _placeFilter.ToList();
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
                _typeFilter.Clear();
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
                    _typeFilter.Add(row.Field<Guid>("id"), row.Field<string>("type"));
                }

                typeComboBox.DataSource = _typeFilter.ToList();
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
                _genreFilter.Clear();
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
                    _genreFilter.Add(row.Field<Guid>("id"), row.Field<string>("genre"));
                }

                genreComboBox.DataSource = _genreFilter.ToList();
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
        private void LoadEvents()
        {
            if (_events != null)
            {
                _events.Clear();
            }
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info;";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadEvents(string search)
        {
            cityComboBox.SelectedIndex = -1;
            placeComboBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = -1;
            genreComboBox.SelectedIndex = -1;
            placeComboBox.Enabled = false;
            typeComboBox.Enabled = false;
            genreComboBox.Enabled = false;
            _events.Clear();
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info
                            WHERE event_name = @search;";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@search", search)
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadEventsFilter(string city)
        {
            _events.Clear();
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info
                            WHERE city = @filter_city;";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@filter_city", city)
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadEventsFilter(string city, string place)
        {
            _events.Clear();
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info
                            WHERE city = @filter_city
                            AND place = @filter_place;";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@filter_city", city),
                    new NpgsqlParameter("@filter_place", place),
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadEventsFilter(string city, string place, string type)
        {
            _events.Clear();
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info
                            WHERE city = @filter_city
                            AND place = @filter_place
                            AND type = @filter_type;";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@filter_city", city),
                    new NpgsqlParameter("@filter_place", place),
                    new NpgsqlParameter("@filter_type", type)
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadEventsFilter(string city, string place, string type, string genre)
        {
            _events.Clear();
            try
            {
                var query = @"SELECT 
                            event_id, 
                            event_name,
                            performers,
                            tickets_available,
                            city,
                            place,
                            type,
                            genre,
                            date_display
                            FROM event_info
                            WHERE city = @filter_city
                            AND place = @filter_place
                            AND type = @filter_type
                            AND genre = @filter_genre;";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    EventsInfo eventInfo = new EventsInfo(
                        id: row.Field<Guid>("event_id"),
                        name: row.Field<string>("event_name"),
                        performers: row.Field<string>("performers"),
                        ticketsAvailable: row.Field<long>("tickets_available"),
                        city: row.Field<string>("city"),
                        place: row.Field<string>("place"),
                        type: row.Field<string>("type"),
                        genre: row.Field<string>("genre"),
                        dateTime: row.Field<string>("date_display")
                    );
                    _events.Add(eventInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            eventsList.DataSource = null;
            eventsList.DataSource = _events;
            eventsList.DisplayMember = "ToString";
        }
        private void LoadTickets()
        {
            if (buyerId == Guid.Empty)
            {
                MessageBox.Show("Отсутствует ID покупателя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _tickets.Clear();

                var query = "SELECT * FROM tickets_info(@buyer_id);";
                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@buyer_id", buyerId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in dt.Rows)
                {
                    string name = row.Field<string>("event_name");
                    string place = row.Field<string>("place");
                    byte[] pdf = row.Field<byte[]>("file");

                    if (name == null || place == null || pdf == null)
                    {
                        MessageBox.Show("Пустой билет", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    _tickets.Add(new TicketsInfo(name, place, pdf));
                }

                ticketsList.DataSource = null;
                ticketsList.DataSource = _tickets;
                ticketsList.DisplayMember = "ToString";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveTicketBtn_Click(object sender, EventArgs e)
        {
            if (ticketsList.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выбрано несколько билетов для сохранения. " +
                    "\nНеобходимо выбрать один.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ticketsList.SelectedItems.Count < 1)
            {
                MessageBox.Show("Не выбран билет для сохранения. " +
                    "\nВыберите билет.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TicketsInfo? t = (TicketsInfo?)ticketsList.SelectedItem;
                if (t == null)
                {
                    MessageBox.Show("Информация о билете пуста.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF-файлы (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.DefaultExt = "pdf";
                        saveFileDialog.AddExtension = true;
                        saveFileDialog.Title = "Сохранить билет";
                        string fileName = $"{t.Name}_({t.Place})_{DateTime.Now.ToString()}.pdf";
                        saveFileDialog.FileName = fileName;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                File.WriteAllBytes(saveFileDialog.FileName, t.Pdf);
                                if (File.Exists(saveFileDialog.FileName))
                                {
                                    DialogResult result = MessageBox.Show(
                                        $"Билет успешно сохранен:\n{saveFileDialog.FileName}" +
                                        $"\n\nОткрыть файл?",
                                        "Успешно", 
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question);

                                    if (result == DialogResult.Yes)
                                    {
                                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                        {
                                            FileName = saveFileDialog.FileName,
                                            UseShellExecute = true
                                        });
                                    }
                                }
                            }
                            catch (UnauthorizedAccessException)
                            {
                                MessageBox.Show("Нет прав для сохранения файла в выбранную папку.",
                                    "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (DirectoryNotFoundException)
                            {
                                MessageBox.Show("Указанная папка не найдена.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"Ошибка при записи файла: {ex.Message}",
                                    "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString(),
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }
        private void filtersOkBtn_Click(object sender, EventArgs e)
        {
            searchText.Clear();
            if (string.IsNullOrEmpty(cityComboBox.Text))
            {
                MessageBox.Show("Не выбрано ни одного параметра фильтрации",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadEvents();
            }
            else if (string.IsNullOrEmpty(placeComboBox.Text))
            {
                LoadEventsFilter(cityComboBox.Text);
            }
            else if (string.IsNullOrEmpty(typeComboBox.Text))
            {
                LoadEventsFilter(cityComboBox.Text,
                    placeComboBox.Text);
            }
            else if (string.IsNullOrEmpty(genreComboBox.Text))
            {
                LoadEventsFilter(cityComboBox.Text,
                    placeComboBox.Text,
                    typeComboBox.Text);
            }
            else
            {
                LoadEventsFilter(cityComboBox.Text,
                    placeComboBox.Text,
                    typeComboBox.Text,
                    genreComboBox.Text);
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchText.Text))
            {
                MessageBox.Show("Не введен запрос. Введите названее мероприятия для поиска в строку поиска.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadEvents(searchText.Text);
            }
        }
        private void cancelFilterBtn_Click(object sender, EventArgs e)
        {
            cityComboBox.SelectedIndex = -1;
            placeComboBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = -1;
            genreComboBox.SelectedIndex = -1;
            placeComboBox.Enabled = false;
            typeComboBox.Enabled = false;
            genreComboBox.Enabled = false;
            LoadEvents();
        }
        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedIndex != -1)
            {
                placeComboBox.Enabled = true;
                typeComboBox.Enabled = false;
                genreComboBox.Enabled = false;
                placeComboBox.SelectedIndex = -1;
                typeComboBox.SelectedIndex = -1;
                genreComboBox.SelectedIndex = -1;
            }
        }
        private void placeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (placeComboBox.SelectedIndex != -1)
            {
                typeComboBox.Enabled = true;
                genreComboBox.Enabled = false;
                typeComboBox.SelectedIndex = -1;
                genreComboBox.SelectedIndex = -1;
            }
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex != -1)
            {
                genreComboBox.Enabled= true;
                genreComboBox.SelectedIndex = -1;
            }
        }
        private void eventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsList.SelectedItem is EventsInfo selectedEvent)
            {
                eventId = selectedEvent.Id;
            }
            else
            {
                eventId = Guid.Empty;
            }
        }
    }
}
