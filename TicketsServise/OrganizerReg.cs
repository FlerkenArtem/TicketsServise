using Npgsql;
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
    public partial class OrganizerReg : Form
    {
        public OrganizerReg()
        {
            InitializeComponent();
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
            var queryResult = DatabaseHelper.ExecuteNonQuery(uniquePhoneQuery, phoneParameters);
            Regex regex = new Regex(@"^\+7 \(9\d{2}\) \d{3}-\d{2}-\d{2}$");
            if (queryResult == 1 && regex.IsMatch(phoneTextBox.Text))
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
            var queryResult = DatabaseHelper.ExecuteNonQuery(uniqueEmailQuery, emailParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (queryResult == 1 && regex.IsMatch(emailTextBox.Text))
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
        private void ogrnTextBox_TextChanged(Object sender, EventArgs e)
        {
            // Проверка правильности ввода ОГРН
            var uniqueOgrnQuery = @"SELECT 1 
                                    FROM ogrn 
                                    WHERE ogrn = @ogrn;";
            var ogrnParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@ogrn", ogrnTextBox.Text),
            };
            var queryResult = DatabaseHelper.ExecuteNonQuery(uniqueOgrnQuery, ogrnParameters);
            Regex regex = new Regex(@"^(\d{13}|\d{15})$");
            if (queryResult == 1 && regex.IsMatch(ogrnTextBox.Text))
            {
                ogrnTextBox.BackColor = Color.LightYellow;
                /* Если ОГРН не уникален (по БД),
                 * ОГРН соответствует regex
                 * - желный */
            }
            else if (regex.IsMatch(ogrnTextBox.Text))
            {
                ogrnTextBox.BackColor = Color.LightGreen;
                /* Если ОГРН не уникален (по БД),
                 * ОГРН соответствует regex
                 * - зеленый */
            }
            else
            {
                ogrnTextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
        }
        private void innTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка ввода ИНН
            var uniqueInnQuery = @"SELECT 1 
                                    FROM inn 
                                    WHERE inn = @inn;";
            var innParameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@inn", innTextBox.Text),
            };
            var queryResult = DatabaseHelper.ExecuteNonQuery(uniqueInnQuery, innParameters);
            Regex regex = new Regex(@"^(\d{12}|\d{10})$");
            if (queryResult == 1 && regex.IsMatch(innTextBox.Text))
            {
                innTextBox.BackColor = Color.LightYellow;
                /* Если ИНН не уникален (по БД),
                 * ИНН соответствует regex
                 * - желный */
            }
            else if (regex.IsMatch(innTextBox.Text))
            {
                innTextBox.BackColor = Color.LightGreen;
                /* Если ИНН уникален (по БД),
                 * ИНН соответствует regex
                 * - зеленый */
            }
            else
            {
                innTextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
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
            var queryResult = DatabaseHelper.ExecuteNonQuery(uniqueLoginQuery, loginParameters);
            Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&*()_\-+=]{8,20}$");
            if (queryResult == 1 && regex.IsMatch(loginTextBox.Text))
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
            DataTable bankDataResults = DatabaseHelper.ExecuteQuery(bankDataQuery, bankDataParameters);
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
        private void bankBikTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^04\d{7}$");
            if (regex.IsMatch(bankBikTextBox.Text))
            {
                bankBikTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                bankBikTextBox.BackColor= Color.DarkRed;
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
                bankInnTextBox.BackColor= Color.DarkRed;
            }
        }
        private void bankKppTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{10}$");
            if (regex.IsMatch(bankKppTextBox.Text))
            {
                bankKppTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                bankKppTextBox.BackColor= Color.DarkRed;
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void okBtn_Click(Object sender, EventArgs e)
        {
            string login = loginTextBox.Text; if (passwordTextBox.Text == password2TextBox.Text);
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
            string openningDate = accountDateTime.Value.ToString("yyyy-MM-DD");
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
                            @new_login, 
                            @new_password,
                            @new_email,
                            @new_phone,
                            @new_name,
                            @new_ogrn,
                            @new_inn,
                            @new_bank_name,
                            @new_bank_bik,
                            @new_bank_corr_account,
                            @new_bank_inn,
                            @new_corr_account,
                            @new_openning_date);";
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
                    new NpgsqlParameter("@new_bank_corr_account", bankCorrAccount),
                    new NpgsqlParameter("@new_bank_inn", bankInn),
                    new NpgsqlParameter("@new_corr_account", orgCorrAccount),
                    new NpgsqlParameter("@new_openning_date", openningDate)
                };
                var res = DatabaseHelper.ExecuteScalar(query, parameters);
                if (res != null && res != DBNull.Value)
                {
                    if (Guid.TryParse(res.ToString(), out Guid parsedGuid))
                    {
                        organizerId = parsedGuid;
                        RegEnd?.Invoke(organizerId);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат GUID.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
