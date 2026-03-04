namespace TicketsServise
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl tabControl;
            eventListPage = new TabPage();
            eventsList = new ListBox();
            buyBtn = new Button();
            searchText = new TextBox();
            searchBtn = new Button();
            filtersGroupBox = new GroupBox();
            cancelFilterBtn = new Button();
            genreComboBox = new ComboBox();
            label4 = new Label();
            typeComboBox = new ComboBox();
            label3 = new Label();
            placeComboBox = new ComboBox();
            label2 = new Label();
            cityComboBox = new ComboBox();
            label1 = new Label();
            filtersOkBtn = new Button();
            ticketPage = new TabPage();
            ticketsList = new ListBox();
            updateBtn = new Button();
            saveTicketBtn = new Button();
            menuStrip = new MenuStrip();
            accountMenu = new ToolStripMenuItem();
            regTool = new ToolStripMenuItem();
            buyerRegTool = new ToolStripMenuItem();
            organizerRegTool = new ToolStripMenuItem();
            loginTool = new ToolStripMenuItem();
            logoutTool = new ToolStripMenuItem();
            organizerMenu = new ToolStripMenuItem();
            newEventTool = new ToolStripMenuItem();
            newPlaceTool = new ToolStripMenuItem();
            ticketsTool = new ToolStripMenuItem();
            ticketsWNTool = new ToolStripMenuItem();
            ticketsWONTool = new ToolStripMenuItem();
            infoMenu = new ToolStripMenuItem();
            aboutTool = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabControl.SuspendLayout();
            eventListPage.SuspendLayout();
            filtersGroupBox.SuspendLayout();
            ticketPage.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(eventListPage);
            tabControl.Controls.Add(ticketPage);
            tabControl.Location = new Point(12, 31);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(758, 510);
            tabControl.TabIndex = 1;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // eventListPage
            // 
            eventListPage.Controls.Add(eventsList);
            eventListPage.Controls.Add(buyBtn);
            eventListPage.Controls.Add(searchText);
            eventListPage.Controls.Add(searchBtn);
            eventListPage.Controls.Add(filtersGroupBox);
            eventListPage.Location = new Point(4, 29);
            eventListPage.Name = "eventListPage";
            eventListPage.Padding = new Padding(3);
            eventListPage.Size = new Size(750, 477);
            eventListPage.TabIndex = 0;
            eventListPage.Text = "Мероприятия";
            eventListPage.UseVisualStyleBackColor = true;
            // 
            // eventsList
            // 
            eventsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsList.FormattingEnabled = true;
            eventsList.Location = new Point(6, 39);
            eventsList.Name = "eventsList";
            eventsList.Size = new Size(570, 384);
            eventsList.TabIndex = 5;
            // 
            // buyBtn
            // 
            buyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buyBtn.Enabled = false;
            buyBtn.Location = new Point(6, 442);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(94, 29);
            buyBtn.TabIndex = 4;
            buyBtn.Text = "К билетам";
            buyBtn.UseVisualStyleBackColor = true;
            buyBtn.Click += buyBtn_Click;
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchText.Location = new Point(6, 6);
            searchText.Name = "searchText";
            searchText.Size = new Size(501, 27);
            searchText.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.Location = new Point(513, 6);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(63, 27);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Поиск";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // filtersGroupBox
            // 
            filtersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            filtersGroupBox.Controls.Add(cancelFilterBtn);
            filtersGroupBox.Controls.Add(genreComboBox);
            filtersGroupBox.Controls.Add(label4);
            filtersGroupBox.Controls.Add(typeComboBox);
            filtersGroupBox.Controls.Add(label3);
            filtersGroupBox.Controls.Add(placeComboBox);
            filtersGroupBox.Controls.Add(label2);
            filtersGroupBox.Controls.Add(cityComboBox);
            filtersGroupBox.Controls.Add(label1);
            filtersGroupBox.Controls.Add(filtersOkBtn);
            filtersGroupBox.Location = new Point(582, 6);
            filtersGroupBox.Name = "filtersGroupBox";
            filtersGroupBox.Size = new Size(162, 465);
            filtersGroupBox.TabIndex = 0;
            filtersGroupBox.TabStop = false;
            filtersGroupBox.Text = "Фильтры";
            // 
            // cancelFilterBtn
            // 
            cancelFilterBtn.Location = new Point(7, 395);
            cancelFilterBtn.Name = "cancelFilterBtn";
            cancelFilterBtn.Size = new Size(149, 29);
            cancelFilterBtn.TabIndex = 9;
            cancelFilterBtn.Text = "Сброс";
            cancelFilterBtn.UseVisualStyleBackColor = true;
            // 
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            genreComboBox.Enabled = false;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(6, 208);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(151, 28);
            genreComboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(7, 185);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 7;
            label4.Text = "Жанр";
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeComboBox.Enabled = false;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(6, 154);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(151, 28);
            typeComboBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(7, 131);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "Тип";
            // 
            // placeComboBox
            // 
            placeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            placeComboBox.Enabled = false;
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(6, 100);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(151, 28);
            placeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Площадка";
            // 
            // cityComboBox
            // 
            cityComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(6, 46);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(151, 28);
            cityComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Город";
            // 
            // filtersOkBtn
            // 
            filtersOkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filtersOkBtn.Location = new Point(6, 430);
            filtersOkBtn.Name = "filtersOkBtn";
            filtersOkBtn.Size = new Size(151, 29);
            filtersOkBtn.TabIndex = 0;
            filtersOkBtn.Text = "Применить";
            filtersOkBtn.UseVisualStyleBackColor = true;
            filtersOkBtn.Click += filtersOkBtn_Click;
            // 
            // ticketPage
            // 
            ticketPage.Controls.Add(ticketsList);
            ticketPage.Controls.Add(updateBtn);
            ticketPage.Controls.Add(saveTicketBtn);
            ticketPage.Location = new Point(4, 29);
            ticketPage.Name = "ticketPage";
            ticketPage.Padding = new Padding(3);
            ticketPage.Size = new Size(750, 477);
            ticketPage.TabIndex = 1;
            ticketPage.Text = "Мои билеты";
            ticketPage.UseVisualStyleBackColor = true;
            // 
            // ticketsList
            // 
            ticketsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketsList.FormattingEnabled = true;
            ticketsList.Location = new Point(6, 6);
            ticketsList.Name = "ticketsList";
            ticketsList.Size = new Size(738, 424);
            ticketsList.TabIndex = 3;
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateBtn.Location = new Point(501, 445);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Обновить";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // saveTicketBtn
            // 
            saveTicketBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveTicketBtn.Location = new Point(601, 445);
            saveTicketBtn.Name = "saveTicketBtn";
            saveTicketBtn.Size = new Size(146, 29);
            saveTicketBtn.TabIndex = 1;
            saveTicketBtn.Text = "Сохранить билет";
            saveTicketBtn.UseVisualStyleBackColor = true;
            saveTicketBtn.Click += saveTicketBtn_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { accountMenu, organizerMenu, infoMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(782, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            accountMenu.DropDownItems.AddRange(new ToolStripItem[] { regTool, loginTool, logoutTool });
            accountMenu.Name = "accountMenu";
            accountMenu.Size = new Size(77, 24);
            accountMenu.Text = "Аккаунт";
            // 
            // regTool
            // 
            regTool.DropDownItems.AddRange(new ToolStripItem[] { buyerRegTool, organizerRegTool });
            regTool.Name = "regTool";
            regTool.Size = new Size(234, 26);
            regTool.Text = "Зарегистрироваться";
            // 
            // buyerRegTool
            // 
            buyerRegTool.Name = "buyerRegTool";
            buyerRegTool.Size = new Size(183, 26);
            buyerRegTool.Text = "Покупатель";
            buyerRegTool.Click += buyerRegTool_Click;
            // 
            // organizerRegTool
            // 
            organizerRegTool.Name = "organizerRegTool";
            organizerRegTool.Size = new Size(183, 26);
            organizerRegTool.Text = "Организатор";
            organizerRegTool.Click += organizerRegTool_Click;
            // 
            // loginTool
            // 
            loginTool.Name = "loginTool";
            loginTool.Size = new Size(234, 26);
            loginTool.Text = "Войти";
            loginTool.Click += loginTool_Click;
            // 
            // logoutTool
            // 
            logoutTool.Enabled = false;
            logoutTool.Name = "logoutTool";
            logoutTool.Size = new Size(234, 26);
            logoutTool.Text = "Выйти";
            logoutTool.Click += logoutTool_Click;
            // 
            // organizerMenu
            // 
            organizerMenu.DropDownItems.AddRange(new ToolStripItem[] { newEventTool, newPlaceTool, ticketsTool });
            organizerMenu.Enabled = false;
            organizerMenu.Name = "organizerMenu";
            organizerMenu.Size = new Size(166, 24);
            organizerMenu.Text = "Меню организатора";
            organizerMenu.Visible = false;
            // 
            // newEventTool
            // 
            newEventTool.Name = "newEventTool";
            newEventTool.Size = new Size(246, 26);
            newEventTool.Text = "Создать мероприятие";
            newEventTool.Click += newEventTool_Click;
            // 
            // newPlaceTool
            // 
            newPlaceTool.Name = "newPlaceTool";
            newPlaceTool.Size = new Size(246, 26);
            newPlaceTool.Text = "Создать площадку";
            newPlaceTool.Click += newPlaceTool_Click;
            // 
            // ticketsTool
            // 
            ticketsTool.DropDownItems.AddRange(new ToolStripItem[] { ticketsWNTool, ticketsWONTool });
            ticketsTool.Name = "ticketsTool";
            ticketsTool.Size = new Size(246, 26);
            ticketsTool.Text = "Создать билеты";
            // 
            // ticketsWNTool
            // 
            ticketsWNTool.Name = "ticketsWNTool";
            ticketsWNTool.Size = new Size(218, 26);
            ticketsWNTool.Text = "С номером места";
            ticketsWNTool.Click += ticketsWNTool_Click;
            // 
            // ticketsWONTool
            // 
            ticketsWONTool.Name = "ticketsWONTool";
            ticketsWONTool.Size = new Size(218, 26);
            ticketsWONTool.Text = "Без номера места";
            ticketsWONTool.Click += ticketsWONTool_Click;
            // 
            // infoMenu
            // 
            infoMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutTool });
            infoMenu.Name = "infoMenu";
            infoMenu.Size = new Size(81, 24);
            infoMenu.Text = "Справка";
            // 
            // aboutTool
            // 
            aboutTool.Name = "aboutTool";
            aboutTool.Size = new Size(187, 26);
            aboutTool.Text = "О программе";
            aboutTool.Click += aboutTool_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 600);
            Name = "MainWindow";
            Text = "Платформа для организации мероприятий и продажи билетов";
            tabControl.ResumeLayout(false);
            eventListPage.ResumeLayout(false);
            eventListPage.PerformLayout();
            filtersGroupBox.ResumeLayout(false);
            filtersGroupBox.PerformLayout();
            ticketPage.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem accountMenu;
        private ToolStripMenuItem regTool;
        private ToolStripMenuItem loginTool;
        private ToolStripMenuItem logoutTool;
        private ToolStripMenuItem buyerRegTool;
        private ToolStripMenuItem organizerRegTool;
        private ToolStripMenuItem organizerMenu;
        private ToolStripMenuItem newEventTool;
        private ToolStripMenuItem infoMenu;
        private ToolStripMenuItem aboutTool;
        private ToolStripMenuItem newPlaceTool;
        private TabControl tabControl;
        private TabPage eventListPage;
        private TabPage ticketPage;
        private GroupBox filtersGroupBox;
        private Button filtersOkBtn;
        private Button buyBtn;
        private TextBox searchText;
        private Button searchBtn;
        private ComboBox cityComboBox;
        private Label label1;
        private ComboBox genreComboBox;
        private Label label4;
        private ComboBox typeComboBox;
        private Label label3;
        private ComboBox placeComboBox;
        private Label label2;
        private Button updateBtn;
        private Button saveTicketBtn;
        private ToolStripMenuItem ticketsTool;
        private ToolStripMenuItem ticketsWNTool;
        private ToolStripMenuItem ticketsWONTool;
        private ListBox eventsList;
        private Button cancelFilterBtn;
        private ListBox ticketsList;
    }
}