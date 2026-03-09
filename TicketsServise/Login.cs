using Npgsql;
using System.Text.RegularExpressions;

namespace TicketsServise
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public event Action<Guid> LoginEnd;
        public event Action<int> AccountType;
        private void loginTextBox_TextChanged(object sender, EventArgs e) // Проверка правильности ввода логина
        {
            Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&*()_\-+=]{8,20}$");
            if (regex.IsMatch(loginTextBox.Text))
            {
                loginTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                loginTextBox.BackColor = Color.DarkRed;
            }
        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e) // Проверка правильности ввода пароля
        {
            if (passwordTextBox.TextLength >= 8)
            {
                passwordTextBox.BackColor = Color.LightGreen;
                // Если пароль содержит 8 символов - зеленый
            }
            else
            {
                passwordTextBox.BackColor = Color.DarkRed;
                // Неправильный - красный
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e) // Закрытие окна
        {
            Close();
        }
        private void okBtn_Click(Object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parametersAccount = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@new_login", login),
                new NpgsqlParameter("@new_password", password)
            };

            try
            {
                // Определение типа аккаунта
                var queryType = @"SELECT 1 FROM account 
                                WHERE type = '019c1a16-e399-73ef-84c8-86938b5f77f5' 
                                AND login = @new_login 
                                AND password = @new_password";

                object result = DatabaseHelper.ExecuteScalar(queryType, parametersAccount);
                int type = Convert.ToInt32(result ?? null) == 1 ? 1 : 0; // 1 - организатор, 0 - покупатель

                AccountType?.Invoke(type);

                // Получение ID пользователя
                var queryId = @"SELECT check_auth(@new_login::varchar, @new_password::varchar);";
                var parametersId = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@new_login", login),
                    new NpgsqlParameter("@new_password", password)
                };
                var res = DatabaseHelper.ExecuteScalar(queryId, parametersId);

                if (res != null && res != DBNull.Value)
                {
                    if (res is Guid guid)
                    {
                        LoginEnd?.Invoke(guid);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка: функция вернула '{res}', ожидался GUID.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка аутентификации: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
