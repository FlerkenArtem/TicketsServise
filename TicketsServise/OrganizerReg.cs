using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class OrganizerReg : Form
    {
        private readonly IDatabase _db;
        public OrganizerReg(IDatabase db)
        {
            InitializeComponent();
            _db = db;
        }
        // Событие завершения регистрации для передачи id в главное окно
        public event Action<Guid> RegEnd;
        // id организатора
        Guid organizerId;
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода номера телефона
            var uniquePhoneQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE phone = @phone;";
            var phoneParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@phone", phoneTextBox.Text),
            };
            var queryResult = _db.ExecuteNonQuery(uniquePhoneQuery, phoneParameters);
            Regex regex = new Regex(@"^\+7 \(9\d{2}\) \d{3}-\d{2}-\d{2}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(phoneTextBox.Text))
            {
                phoneTextBox.BackColor = Color.LightYellow;
                // Номер в правильном формате, но повторяется - выделяется желтым
            }
            else if (regex.IsMatch(phoneTextBox.Text))
            {
                phoneTextBox.BackColor = Color.LightGreen;
                // Номер правильный - зеленый
            }
            else
            {
                phoneTextBox.BackColor = Color.DarkRed;
                // Номер неправильный - красный
            }
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода адреса электронной почты
            var uniqueEmailQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE email = @email;";
            var emailParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", emailTextBox.Text),
            };
            var queryResult = _db.ExecuteNonQuery(uniqueEmailQuery, emailParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(emailTextBox.Text))
            {
                emailTextBox.BackColor = Color.LightYellow;
                // Правильный формат, но повторяется - желтый
            }
            else if (regex.IsMatch(emailTextBox.Text))
            {
                emailTextBox.BackColor = Color.LightGreen;
                // Правильный - зеленый
            }
            else
            {
                emailTextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода пароля
            if (passwordTextBox.TextLength >= 8 && (passwordTextBox.Text == password2TextBox.Text || password2TextBox.TextLength == 0))
            {
                passwordTextBox.BackColor = Color.LightGreen;
                // Если пароль содержит 8 символов и совпадает с повтором - зеленый
            }
            else
            {
                passwordTextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
        }
        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода повтора пароля
            if (password2TextBox.TextLength >= 8 && password2TextBox.Text == passwordTextBox.Text)
            {
                password2TextBox.BackColor = Color.LightGreen;
                // Если повтор пароля содержит 8 символов и совпадает с паролем - зеленый
            }
            else
            {
                password2TextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода названия организации
            Regex regex = new Regex(@"^[а-яА-ЯёЁ\s\-""]+$");
            if (regex.IsMatch(nameTextBox.Text) && nameTextBox.TextLength >= 2 && char.IsUpper(nameTextBox.Text[0]))
            {
                nameTextBox.BackColor = Color.LightGreen;
                /* Если название организации совпадает с regex,
                 * длиннее 2 символов,
                 * начинается с большой буквы 
                 * - зеленый */
            }
            else
            {
                nameTextBox.BackColor = Color.DarkRed;
                // Неправильное - красным
            }
        }
        private void ogrnTextBox_TextChanged(object sender, EventArgs e)
        {
            bool formatOk = ValidationHelper.IsValidOgrn(ogrnTextBox.Text);
            bool isUnique = CheckOgrnUniqueness(ogrnTextBox.Text);
            ogrnTextBox.BackColor = formatOk ? (isUnique ? Color.LightGreen : Color.LightYellow) : Color.DarkRed;
        }
        private bool CheckOgrnUniqueness(string ogrn)
        {
            var query = "SELECT 1 FROM ogrn WHERE ogrn = @ogrn";
            var param = new NpgsqlParameter[]
            {
                new NpgsqlParameter ("@ogrn", ogrn)
            };
            var result = _db.ExecuteScalar(query, param);
            return Convert.ToInt32(result) != 1;
        }
        private void innTextBox_TextChanged(object sender, EventArgs e)
        {
            bool formatOk = ValidationHelper.IsValidInn(innTextBox.Text, true); // для организации
            bool isUnique = CheckInnUniqueness(innTextBox.Text);
            innTextBox.BackColor = formatOk ? (isUnique ? Color.LightGreen : Color.LightYellow) : Color.DarkRed;
        }
        private bool CheckInnUniqueness(string inn)
        {
            var query = "SELECT 1 FROM inn WHERE inn = @inn";
            var param = new NpgsqlParameter[]
            {
                new NpgsqlParameter ("@inn", inn)
            };
            var result = _db.ExecuteScalar(query, param);
            return Convert.ToInt32(result) != 1;
        }
        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка ввода логина
            var uniqueLoginQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE login = @login;";
            var loginParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@login", loginTextBox.Text),
            };
            var queryResult = _db.ExecuteScalar(uniqueLoginQuery, loginParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&*()_\-+=]{8,20}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(loginTextBox.Text))
            {
                loginTextBox.BackColor = Color.LightYellow;
                /* Если логин не уникален (по БД),
                 * логин соответствует regex
                 * - желный */
            }
            else if (regex.IsMatch(loginTextBox.Text))
            {
                loginTextBox.BackColor = Color.LightGreen;
                /* Если логин уникален (по БД),
                 * логин соответствует regex
                 * - зеелный */
            }
            else
            {
                loginTextBox.BackColor = Color.DarkRed;
                // неправильный - красный
            }
        }
        private void bankNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 
             * Внесение данных о банке после выбора названия банка из списка
             * Если такой в БД банк присутствует, то из БД загружаются данные:
             * 1. БИК
             * 2. КПП
             * 3. Корреспондентский счет
             * 4. ИНН
             */
            string name = bankNameComboBox.Text;
            string? bik;
            string? kpp;
            string? account;
            string? inn;
            var bankDataQuery = @"SELECT bik.bik, kpp.kpp, corr_account.account, inn.inn 
                                FROM bank
                                WHERE bank.name = @bank_name
                                JOIN bik ON bik.id = bank.bik
                                JOIN kpp ON kpp.id = bank.kpp
                                JOIN corr_account ON corr_account.id = bank.corr_account
                                JOIN inn ON inn.id = bank.inn;";
            var bankDataParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@bank_name", name)
            };
            DataTable bankDataResults = _db.ExecuteQuery(bankDataQuery, bankDataParameters);
            if (bankDataResults != null && bankDataResults.Rows.Count == 1)
            {
                bik = bankDataResults.Rows[0]["bik"].ToString();
                kpp = bankDataResults.Rows[0]["kpp"].ToString();
                account = bankDataResults.Rows[0]["corr_account"].ToString();
                inn = bankDataResults.Rows[0]["inn"].ToString();
                if (bik == null || kpp == null || account == null || inn == null)
                {
                    return;
                }
                else
                {
                    bankBikTextBox.Text = bik;
                    bankKppTextBox.Text = kpp;
                    bankCorrAccountTextBox.Text = account;
                    bankInnTextBox.Text = inn;
                }
            }
        }
        private void bankInnTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{10}$");
            if (regex.IsMatch(bankInnTextBox.Text))
            {
                bankInnTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                bankInnTextBox.BackColor = Color.DarkRed;
            }
        }
        private void bankBikTextBox_TextChanged(object sender, EventArgs e)
        {
            bankBikTextBox.BackColor = ValidationHelper.IsValidBik(bankBikTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void bankKppTextBox_TextChanged(object sender, EventArgs e)
        {
            bankKppTextBox.BackColor = ValidationHelper.IsValidKpp(bankKppTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void bankCorrAccountTextBox_TextChanged(object sender, EventArgs e)
        {
            bankCorrAccountTextBox.BackColor = ValidationHelper.IsValidCorrAccount(bankCorrAccountTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void orgCorrAccountTextBox_TextChanged(object sender, EventArgs e)
        {
            orgCorrAccountTextBox.BackColor = ValidationHelper.IsValidOrgAccount(orgCorrAccountTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password;
            if (passwordTextBox.Text == password2TextBox.Text)
            {
                password = passwordTextBox.Text;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string name = nameTextBox.Text;
            string ogrn = ogrnTextBox.Text;
            string inn = innTextBox.Text;
            string bankName = bankNameComboBox.Text;
            string bankBik = bankBikTextBox.Text;
            string bankCorrAccount = bankCorrAccountTextBox.Text;
            string bankKpp = bankKppTextBox.Text;
            string bankInn = bankInnTextBox.Text;
            string orgCorrAccount = orgCorrAccountTextBox.Text;
            string openningDate = accountDateTime.Value.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(ogrn) ||
                string.IsNullOrEmpty(bankName) ||
                string.IsNullOrEmpty(bankBik) ||
                string.IsNullOrEmpty(bankCorrAccount) ||
                string.IsNullOrEmpty(bankKpp) ||
                string.IsNullOrEmpty(bankInn) ||
                string.IsNullOrEmpty(orgCorrAccount) ||
                string.IsNullOrEmpty(openningDate))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var query = @"SELECT organizer_reg(
                            @new_login::varchar, 
                            @new_password::varchar,
                            @new_email::varchar,
                            @new_phone::char(18),
                            @new_name::varchar,
                            @new_ogrn::varchar,
                            @new_inn::varchar,
                            @new_bank_name::varchar,
                            @new_bank_bik::char(9),
                            @new_bank_kpp::char(9),
                            @new_bank_corr_account::char(20),
                            @new_bank_inn::varchar,
                            @new_corr_account::char(20),
                            @new_openning_date::date);";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@new_login", login),
                    new NpgsqlParameter("@new_password", password),
                    new NpgsqlParameter("@new_email", email),
                    new NpgsqlParameter("@new_phone", phone),
                    new NpgsqlParameter("@new_name", name),
                    new NpgsqlParameter("@new_ogrn", ogrn),
                    new NpgsqlParameter("@new_inn", inn),
                    new NpgsqlParameter("@new_bank_name", bankName),
                    new NpgsqlParameter("@new_bank_bik", bankBik),
                    new NpgsqlParameter("@new_bank_kpp", bankKpp),
                    new NpgsqlParameter("@new_bank_corr_account", bankCorrAccount),
                    new NpgsqlParameter("@new_bank_inn", bankInn),
                    new NpgsqlParameter("@new_corr_account", orgCorrAccount),
                    new NpgsqlParameter("@new_openning_date", openningDate)
                };
                var res = _db.ExecuteScalar(query, parameters);
                if (res != null && res != DBNull.Value)
                {
                    if (res is Guid guid)
                    {
                        organizerId = guid;
                        RegEnd.Invoke(organizerId);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка: функция вернула '{res.ToString()}', ожидался GUID.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
