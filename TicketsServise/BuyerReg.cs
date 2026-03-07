using Npgsql;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class BuyerReg : Form
    {
        public BuyerReg()
        {
            InitializeComponent();
        }
        public event Action<Guid> RegEnd;
        Guid buyerId;
        private void phoneTextBox_TextChanged(object sender, EventArgs e) // проверка правильности и уникальности номера телефона
        {
            var uniquePhoneQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE phone = @phone;";
            var phoneParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@phone", phoneTextBox.Text),
            };
            var queryResult = DatabaseHelper.ExecuteScalar(uniquePhoneQuery, phoneParameters);
            Regex regex = new Regex(@"^\+7 \(9\d{2}\) \d{3}-\d{2}-\d{2}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(phoneTextBox.Text))
            {
                phoneTextBox.BackColor = Color.LightYellow;
            }
            else if (regex.IsMatch(phoneTextBox.Text))
            {
                phoneTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                phoneTextBox.BackColor = Color.DarkRed;
            }
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e) // проверка правильности и уникальности email
        {
            var uniqueEmailQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE email = @email;";
            var emailParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", emailTextBox.Text),
            };
            var queryResult = DatabaseHelper.ExecuteScalar(uniqueEmailQuery, emailParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(emailTextBox.Text))
            {
                emailTextBox.BackColor = Color.LightYellow;
            }
            else if (regex.IsMatch(emailTextBox.Text))
            {
                emailTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                emailTextBox.BackColor = Color.DarkRed;
            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e) // проверка правильности и совпвдения паролей
        {
            if (passwordTextBox.TextLength >= 8 && (passwordTextBox.Text == password2TextBox.Text || password2TextBox.TextLength == 0))
            {
                passwordTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                passwordTextBox.BackColor = Color.DarkRed;
            }
        }
        private void password2TextBox_TextChanged(object sender, EventArgs e) // проверка правильности и совпвдения паролей
        {
            if (password2TextBox.TextLength >= 8 && password2TextBox.Text == passwordTextBox.Text)
            {
                password2TextBox.BackColor = Color.LightGreen;
            }
            else
            {
                password2TextBox.BackColor = Color.DarkRed;
            }
        }
        private void surnameTextBox_TextChanged(object sender, EventArgs e) // проверка правильности Фамилии
        {
            Regex regex = new Regex(@"^[А-Яа-яЁё]+([-][А-Яа-яЁё]+)*$");
            if (regex.IsMatch(surnameTextBox.Text) && surnameTextBox.TextLength >= 2 && char.IsUpper(surnameTextBox.Text[0]))
            {
                surnameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                surnameTextBox.BackColor = Color.DarkRed;
            }
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e) // проверка правильности имени
        {
            Regex regex = new Regex(@"^[А-Яа-яЁё]+$");
            if (regex.IsMatch(nameTextBox.Text) && nameTextBox.TextLength >= 2 && char.IsUpper(nameTextBox.Text[0]))
            {
                nameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                nameTextBox.BackColor = Color.DarkRed;
            }
        }
        private void patronymicTextBox_TextChanged(object sender, EventArgs e) // проверка правильности отчества
        {
            Regex regex = new Regex(@"^$|^[А-Яа-яЁё]+$");
            if ((regex.IsMatch(patronymicTextBox.Text) && patronymicTextBox.TextLength >= 2 && char.IsUpper(patronymicTextBox.Text[0]) ||
                patronymicTextBox.TextLength == 0))
            {
                patronymicTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                patronymicTextBox.BackColor = Color.DarkRed;
            }
        }
        private void loginTextBox_TextChanged(object sender, EventArgs e) // проверка правильности и уникальности логина
        {
            var uniqueLoginQuery = @"SELECT 1 
                                    FROM account 
                                    WHERE login = @login;";
            var loginParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@login", loginTextBox.Text),
            };
            var queryResult = DatabaseHelper.ExecuteScalar(uniqueLoginQuery, loginParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&*()_\-+=]{8,20}$");
            if (Convert.ToInt32(queryResult) == 1 && regex.IsMatch(loginTextBox.Text))
            {
                loginTextBox.BackColor = Color.LightYellow;
            }
            else if (regex.IsMatch(loginTextBox.Text))
            {
                loginTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                loginTextBox.BackColor = Color.DarkRed;
            }
        }
        private void okBtn_Click(object sender, EventArgs e) // Обработка события нажатия ОК, завершение регистрации
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
            string surname = surnameTextBox.Text;
            string name = nameTextBox.Text;
            string? patronymic = patronymicTextBox.Text;


            if (string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Не все необходимые поля заполнены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var buyerRegQuery = @"SELECT buyer_reg(
                                    @new_login::varchar, 
                                    @new_password::varchar, 
                                    @new_email::varchar, 
                                    @new_phone::varchar, 
                                    @new_surname::varchar, 
                                    @new_name::varchar, 
                                    @new_patronymic::varchar);";
                var buyerRegParameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@new_login", login),
                    new NpgsqlParameter("@new_password", password),
                    new NpgsqlParameter("@new_email", email),
                    new NpgsqlParameter("@new_phone", phone),
                    new NpgsqlParameter("@new_surname", surname),
                    new NpgsqlParameter("@new_name", name),
                    new NpgsqlParameter("@new_patronymic", patronymic)
                };
                var buyerResult = DatabaseHelper.ExecuteScalar(buyerRegQuery, buyerRegParameters);
                if (buyerResult != null && buyerResult != DBNull.Value)
                {
                    if (buyerId is Guid guid)
                    {
                        buyerId = guid;
                    }
                    else
                    {
                        string strRes = buyerResult.ToString();
                        if (Guid.TryParse(strRes, out Guid parsedGuid))
                        {
                            buyerId = parsedGuid;
                            RegEnd.Invoke(buyerId);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка: функция вернула '{strRes}', ожидался GUID.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e) // Отмена - закрытие окна
        {
            Close();
        }
    }
}
