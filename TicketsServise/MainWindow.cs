using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            buyerReg.RegEnd += (id) =>
            {
                buyerId = id;
                newCardTool.Available = true;
                logoutTool.Available = true;
                buyBtn.Enabled = true;
            };
            buyerReg.ShowDialog();
        }
        private void organizerRegTool_Click(object sender, EventArgs e)
        {
            OrganizerReg organizerReg = new OrganizerReg();
            organizerReg.RegEnd += (id) =>
            {
                organizerId = id;
                logoutTool.Available = true;
                organizerMenu.Visible = true;
                organizerMenu.Available = true;
            };
            organizerReg.ShowDialog();
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

        }
    }
}
