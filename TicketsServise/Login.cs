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
        private void loginTextBox_TextChanged(object sender, EventArgs e)
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
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка правильности ввода пароля
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
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void okBtn_Click(Object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(login) ||
                    string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var parametersAccount = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@new_login", login),
                        new NpgsqlParameter("@new_password", password)
                    };
                try // определение типа аккаунта
                {
                    var queryType = @"SELECT 1 FROM account 
                                    WHERE account_type = '019c1a16-e399-73ef-84c8-86938b5f77f5' 
                                    AND login = @new_login 
                                    AND password = @new_password";
                    int type;
                    if (DatabaseHelper.ExecuteNonQuery(queryType, parametersAccount) == 1)
                    {
                        type = 1; // организатор
                    }
                    else
                    {
                        type = 0; // покупатель
                    }
                    AccountType.Invoke(type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось определить тип аккаунта: {ex.Message}.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try // определение id
                {
                    var queryId = @"SELECT check_auth( 
                                @new_login, 
                                @new_password)";
                    var res = DatabaseHelper.ExecuteScalar(queryId, parametersAccount);
                    if (res != null && res != DBNull.Value)
                    {
                        if (Guid.TryParse(res.ToString(), out Guid parsedGuid))
                        {
                            LoginEnd.Invoke(parsedGuid);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка аутентификации пользователя: {ex}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
