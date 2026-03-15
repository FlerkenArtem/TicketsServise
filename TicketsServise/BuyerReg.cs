using Npgsql;

namespace TicketsServise
{
    public partial class BuyerReg : BaseForm
    {
        public event Action<Guid> RegEnd;
        private Guid buyerId;

        public BuyerReg(IDatabase db) : base(db)
        {
            InitializeComponent();
        }
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            bool formatOk = ValidationHelper.IsValidPhone(phoneTextBox.Text);
            bool isUnique = CheckPhoneUniqueness(phoneTextBox.Text);
            phoneTextBox.BackColor = formatOk ? (isUnique ? Color.LightGreen : Color.LightYellow) : Color.DarkRed;
        }
        private bool CheckPhoneUniqueness(string phone)
        {
            var query = "SELECT 1 FROM account WHERE phone = @phone";
            var param = new NpgsqlParameter("@phone", phone);
            var result = ExecuteScalar(query, param);
            return Convert.ToInt32(result) != 1;
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            bool formatOk = ValidationHelper.IsValidEmail(emailTextBox.Text);
            bool isUnique = CheckEmailUniqueness(emailTextBox.Text);
            emailTextBox.BackColor = formatOk ? (isUnique ? Color.LightGreen : Color.LightYellow) : Color.DarkRed;
        }
        private bool CheckEmailUniqueness(string email)
        {
            var query = "SELECT 1 FROM account WHERE email = @email";
            var param = new NpgsqlParameter("@email", email);
            var result = ExecuteScalar(query, param);
            return Convert.ToInt32(result) != 1;
        }
        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            bool formatOk = ValidationHelper.IsValidLogin(loginTextBox.Text);
            bool isUnique = CheckLoginUniqueness(loginTextBox.Text);
            loginTextBox.BackColor = formatOk ? (isUnique ? Color.LightGreen : Color.LightYellow) : Color.DarkRed;
        }
        private bool CheckLoginUniqueness(string login)
        {
            var query = "SELECT 1 FROM account WHERE login = @login";
            var param = new NpgsqlParameter("@login", login);
            var result = ExecuteScalar(query, param);
            return Convert.ToInt32(result) != 1;
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            bool valid = ValidationHelper.IsValidPassword(passwordTextBox.Text) &&
                        (passwordTextBox.Text == password2TextBox.Text || password2TextBox.TextLength == 0);
            passwordTextBox.BackColor = valid ? Color.LightGreen : Color.DarkRed;
        }
        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            bool valid = password2TextBox.TextLength >= 8 && password2TextBox.Text == passwordTextBox.Text;
            password2TextBox.BackColor = valid ? Color.LightGreen : Color.DarkRed;
        }
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            surnameTextBox.BackColor = ValidationHelper.IsValidName(surnameTextBox.Text, true)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = ValidationHelper.IsValidName(nameTextBox.Text, false)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            patronymicTextBox.BackColor = ValidationHelper.IsValidPatronymic(patronymicTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password;
            if (passwordTextBox.Text == password2TextBox.Text)
                password = passwordTextBox.Text;
            else
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string surname = surnameTextBox.Text;
            string name = nameTextBox.Text;
            string? patronymic = patronymicTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = @"SELECT buyer_reg(
                                    @new_login::varchar, @new_password::varchar, @new_email::varchar,
                                    @new_phone::varchar, @new_surname::varchar, @new_name::varchar,
                                    @new_patronymic::varchar);";
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@new_login", login),
                    new NpgsqlParameter("@new_password", password),
                    new NpgsqlParameter("@new_email", email),
                    new NpgsqlParameter("@new_phone", phone),
                    new NpgsqlParameter("@new_surname", surname),
                    new NpgsqlParameter("@new_name", name),
                    new NpgsqlParameter("@new_patronymic", string.IsNullOrEmpty(patronymic) ? DBNull.Value : (object)patronymic)
                };
                var result = ExecuteScalar(query, parameters);
                if (result != null && result != DBNull.Value && Guid.TryParse(result.ToString(), out Guid parsedGuid))
                {
                    buyerId = parsedGuid;
                    RegEnd.Invoke(buyerId);
                    Close();
                }
                else
                {
                    MessageBox.Show($"Ошибка регистрации: функция вернула '{result}'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e) => Close();
    }
}