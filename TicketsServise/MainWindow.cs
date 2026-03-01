namespace TicketsServise
{
    public partial class MainWindow : Form
    {
        private Guid buyerId;
        private Guid organizerId;
        public MainWindow()
        {
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
                UpdateTicketList();
            }
        }
        private void logoutTool_Click(object sender, EventArgs e)
        {
            buyerId = Guid.Empty;
            organizerId = Guid.Empty;
            newCardTool.Enabled = false;
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
            buyerMenu.Visible = true;
            buyerMenu.Available = true;
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

        }

        private void newCardTool_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTicketList()
        {

        }
    }
}
