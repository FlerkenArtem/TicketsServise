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
        private List<EventsInfo> _events;
        private List<TicketsInfo> _tickets;
        private Dictionary<Guid, string> _cityFilter;
        private Dictionary<Guid, string> _placeFilter;
        private Dictionary<Guid, string> _typeFilter;
        private Dictionary<Guid, string> _genreFilter;
        public MainWindow()
        {
            LoadEvents();
            InitializeComponent();
        }
        private void buyerRegTool_Click(object sender, EventArgs e)
        {
            BuyerReg buyerReg = new BuyerReg();
            buyerReg.ShowDialog();
            buyerReg.RegEnd += (id) =>
            {
                BuyerToolsLoad(id);
            };
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
            login.ShowDialog();
            login.AccountType += (type) =>
            {
                if (type == 1)
                {
                    login.LoginEnd += (id) =>
                    {
                        OrganizerToolsLoad(id);
                    };
                }
                else if (type == 2)
                {
                    login.LoginEnd += (id) =>
                    {
                        BuyerToolsLoad(id);
                    };
                }
            };
        }
        private void OrganizerToolsLoad(Guid newId)
        {
            buyerId = Guid.Empty;
            organizerId = newId;
            logoutTool.Available = true;
            organizerMenu.Visible = true;
            organizerMenu.Available = true;
            loginTool.Visible = false;
            loginTool.Available = false;
            buyerRegTool.Visible = false;
            buyerRegTool.Available = false;
            organizerRegTool.Visible = false;
            organizerRegTool.Available = false;
        }
        private void BuyerToolsLoad(Guid newId)
        {
            organizerId = Guid.Empty;
            buyerId = newId;
            logoutTool.Available = true;
            buyBtn.Enabled = true;
            loginTool.Visible = false;
            loginTool.Available = false;
            buyerRegTool.Visible = false;
            buyerRegTool.Available = false;
            organizerRegTool.Visible = false;
            organizerRegTool.Available = false;
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
        private void LoadEvents()
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
        }
        private void LoadEvents(string city)
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
        }
        private void LoadEvents(string city, string place)
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
        }
        private void LoadEvents(string city, string place, string type)
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
        }
        private void LoadEvents(string city, string place, string type, string genre)
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
        }
        private void LoadTickets()
        {
            if (buyerId != Guid.Empty)
            {
                try
                {
                    var query = "SELECT tickets_info (@buyer_id);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@buyer_id", buyerId)
                    };
                    DataTable dt = DatabaseHelper.ExecuteQuery(query);
                    foreach (DataRow row in dt.Rows)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Отсутствует ID покупателя",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void saveTicketBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void filtersOkBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
