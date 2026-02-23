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
            buyBtn = new Button();
            eventsView = new DataGridView();
            searchText = new TextBox();
            searchBtn = new Button();
            filtersGroupBox = new GroupBox();
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
            updateBtn = new Button();
            saveTicketBtn = new Button();
            ticketView = new DataGridView();
            menuStrip = new MenuStrip();
            accountMenu = new ToolStripMenuItem();
            regTool = new ToolStripMenuItem();
            buyerRegTool = new ToolStripMenuItem();
            organizerRegTool = new ToolStripMenuItem();
            loginTool = new ToolStripMenuItem();
            logoutTool = new ToolStripMenuItem();
            newCardTool = new ToolStripMenuItem();
            OrganizerMenu = new ToolStripMenuItem();
            newEventTool = new ToolStripMenuItem();
            newPlaceTool = new ToolStripMenuItem();
            infoMenu = new ToolStripMenuItem();
            aboutTool = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabControl.SuspendLayout();
            eventListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventsView).BeginInit();
            filtersGroupBox.SuspendLayout();
            ticketPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketView).BeginInit();
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
            eventListPage.Controls.Add(buyBtn);
            eventListPage.Controls.Add(eventsView);
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
            // buyBtn
            // 
            buyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buyBtn.Location = new Point(6, 442);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(94, 29);
            buyBtn.TabIndex = 4;
            buyBtn.Text = "К билетам";
            buyBtn.UseVisualStyleBackColor = true;
            // 
            // eventsView
            // 
            eventsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsView.Location = new Point(6, 39);
            eventsView.Name = "eventsView";
            eventsView.RowHeadersWidth = 51;
            eventsView.Size = new Size(570, 400);
            eventsView.TabIndex = 3;
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
            // 
            // filtersGroupBox
            // 
            filtersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // 
            // ticketPage
            // 
            ticketPage.Controls.Add(updateBtn);
            ticketPage.Controls.Add(saveTicketBtn);
            ticketPage.Controls.Add(ticketView);
            ticketPage.Location = new Point(4, 29);
            ticketPage.Name = "ticketPage";
            ticketPage.Padding = new Padding(3);
            ticketPage.Size = new Size(750, 477);
            ticketPage.TabIndex = 1;
            ticketPage.Text = "Мои билеты";
            ticketPage.UseVisualStyleBackColor = true;
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
            // 
            // ticketView
            // 
            ticketView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketView.Location = new Point(6, 6);
            ticketView.Name = "ticketView";
            ticketView.RowHeadersWidth = 51;
            ticketView.Size = new Size(738, 433);
            ticketView.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { accountMenu, OrganizerMenu, infoMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(782, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            accountMenu.DropDownItems.AddRange(new ToolStripItem[] { regTool, loginTool, logoutTool, newCardTool });
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
            buyerRegTool.Size = new Size(224, 26);
            buyerRegTool.Text = "Покупатель";
            buyerRegTool.Click += buyerRegTool_Click;
            // 
            // organizerRegTool
            // 
            organizerRegTool.Name = "organizerRegTool";
            organizerRegTool.Size = new Size(224, 26);
            organizerRegTool.Text = "Организатор";
            organizerRegTool.Click += organizerRegTool_Click;
            // 
            // loginTool
            // 
            loginTool.Name = "loginTool";
            loginTool.Size = new Size(234, 26);
            loginTool.Text = "Войти";
            // 
            // logoutTool
            // 
            logoutTool.Enabled = false;
            logoutTool.Name = "logoutTool";
            logoutTool.Size = new Size(234, 26);
            logoutTool.Text = "Выйти";
            // 
            // newCardTool
            // 
            newCardTool.Enabled = false;
            newCardTool.Name = "newCardTool";
            newCardTool.Size = new Size(234, 26);
            newCardTool.Text = "Добавить карту";
            // 
            // OrganizerMenu
            // 
            OrganizerMenu.DropDownItems.AddRange(new ToolStripItem[] { newEventTool, newPlaceTool });
            OrganizerMenu.Enabled = false;
            OrganizerMenu.Name = "OrganizerMenu";
            OrganizerMenu.Size = new Size(166, 24);
            OrganizerMenu.Text = "Меню организатора";
            OrganizerMenu.Visible = false;
            // 
            // newEventTool
            // 
            newEventTool.Name = "newEventTool";
            newEventTool.Size = new Size(246, 26);
            newEventTool.Text = "Создать мероприятие";
            // 
            // newPlaceTool
            // 
            newPlaceTool.Name = "newPlaceTool";
            newPlaceTool.Size = new Size(246, 26);
            newPlaceTool.Text = "Создать площадку";
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
            ((System.ComponentModel.ISupportInitialize)eventsView).EndInit();
            filtersGroupBox.ResumeLayout(false);
            filtersGroupBox.PerformLayout();
            ticketPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ticketView).EndInit();
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
        private ToolStripMenuItem OrganizerMenu;
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
        private DataGridView eventsView;
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
        private ToolStripMenuItem newCardTool;
        private Button updateBtn;
        private Button saveTicketBtn;
        private DataGridView ticketView;
    }
}