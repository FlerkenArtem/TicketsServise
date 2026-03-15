using Npgsql;

namespace TicketsServise
{
    public partial class Login : BaseForm
    {
        public event Action<Guid> LoginEnd;
        public event Action<int> AccountType;

        public Login(IDatabase db) : base(db)
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            loginTextBox.BackColor = ValidationHelper.IsValidLogin(loginTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = ValidationHelper.IsValidPassword(passwordTextBox.Text)
                ? Color.LightGreen : Color.DarkRed;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@new_login", login),
                new NpgsqlParameter("@new_password", password)
            };

            try
            {
                // Определение типа аккаунта
                string queryType = $@"SELECT 1 FROM account 
                                    WHERE type = '{Constants.OrganizerAccountTypeId}' 
                                    AND login = @new_login 
                                    AND password = @new_password";
                object result = ExecuteScalar(queryType, parameters);
                int type = Convert.ToInt32(result) == 1 ? 1 : 0;
                AccountType?.Invoke(type);

                // Получение ID пользователя
                string queryId = "SELECT check_auth(@new_login::varchar, @new_password::varchar);";
                var res = ExecuteScalar(queryId, parameters);
                if (res != null && res != DBNull.Value && Guid.TryParse(res.ToString(), out Guid guid))
                {
                    LoginEnd.Invoke(guid);
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка аутентификации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e) => Close();
    }
}