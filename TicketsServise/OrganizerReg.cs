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
        public event Action<Guid> RegEnd;
        Guid organizerId;
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
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
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
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
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
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
        private void password2TextBox_TextChanged(object sender, EventArgs e)
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
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[а-яА-ЯёЁ\s\-""]+$");
            if (regex.IsMatch(nameTextBox.Text) && nameTextBox.TextLength >= 2 && char.IsUpper(nameTextBox.Text[0]))
            {
                nameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                nameTextBox.BackColor = Color.DarkRed;
            }
        }
        private void ogrnTextBox_TextChanged(Object sender, EventArgs e)
        {
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
            }
            else if (regex.IsMatch(ogrnTextBox.Text))
            {
                ogrnTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                ogrnTextBox.BackColor= Color.DarkRed;
            }
        }
        private void innTextBox_TextChanged(object sender, EventArgs e)
        {
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
            }
            else if (regex.IsMatch(innTextBox.Text))
            {
                innTextBox.BackColor = Color.LightGreen;
            }
            else 
            {
                innTextBox.BackColor= Color.DarkRed;
            }
        }
    }
}
