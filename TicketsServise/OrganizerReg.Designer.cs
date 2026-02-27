namespace TicketsServise
{
    partial class OrganizerReg
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
            okBtn = new Button();
            cancelBtn = new Button();
            panel = new Panel();
            ogrnTextBox = new TextBox();
            innTextBox = new TextBox();
            phoneTextBox = new MaskedTextBox();
            label15 = new Label();
            accountDateTime = new DateTimePicker();
            orgCorrAccountTextBox = new MaskedTextBox();
            bankCorrAccountTextBox = new MaskedTextBox();
            bankInnTextBox = new MaskedTextBox();
            bankKppTextBox = new MaskedTextBox();
            bankBikTextBox = new MaskedTextBox();
            label12 = new Label();
            label14 = new Label();
            label11 = new Label();
            label13 = new Label();
            label10 = new Label();
            label9 = new Label();
            bankNameComboBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            nameTextBox = new TextBox();
            label5 = new Label();
            password2TextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            loginTextBox = new TextBox();
            label1 = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(376, 412);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 19;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(276, 412);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.Controls.Add(ogrnTextBox);
            panel.Controls.Add(innTextBox);
            panel.Controls.Add(phoneTextBox);
            panel.Controls.Add(label15);
            panel.Controls.Add(accountDateTime);
            panel.Controls.Add(orgCorrAccountTextBox);
            panel.Controls.Add(bankCorrAccountTextBox);
            panel.Controls.Add(bankInnTextBox);
            panel.Controls.Add(bankKppTextBox);
            panel.Controls.Add(bankBikTextBox);
            panel.Controls.Add(label12);
            panel.Controls.Add(label14);
            panel.Controls.Add(label11);
            panel.Controls.Add(label13);
            panel.Controls.Add(label10);
            panel.Controls.Add(label9);
            panel.Controls.Add(bankNameComboBox);
            panel.Controls.Add(label8);
            panel.Controls.Add(label7);
            panel.Controls.Add(label6);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(label5);
            panel.Controls.Add(password2TextBox);
            panel.Controls.Add(label4);
            panel.Controls.Add(emailTextBox);
            panel.Controls.Add(label3);
            panel.Controls.Add(passwordTextBox);
            panel.Controls.Add(label2);
            panel.Controls.Add(loginTextBox);
            panel.Controls.Add(label1);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(458, 394);
            panel.TabIndex = 21;
            // 
            // ogrnTextBox
            // 
            ogrnTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ogrnTextBox.Location = new Point(3, 341);
            ogrnTextBox.Name = "ogrnTextBox";
            ogrnTextBox.Size = new Size(431, 27);
            ogrnTextBox.TabIndex = 55;
            ogrnTextBox.TextChanged += ogrnTextBox_TextChanged;
            // 
            // innTextBox
            // 
            innTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            innTextBox.Location = new Point(3, 394);
            innTextBox.Name = "innTextBox";
            innTextBox.Size = new Size(431, 27);
            innTextBox.TabIndex = 54;
            innTextBox.TextChanged += innTextBox_TextChanged;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTextBox.Location = new Point(3, 182);
            phoneTextBox.Mask = "+7 (\\900) 000-00-00";
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(431, 27);
            phoneTextBox.TabIndex = 52;
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 159);
            label15.Name = "label15";
            label15.Size = new Size(127, 20);
            label15.TabIndex = 51;
            label15.Text = "Номер телефона";
            // 
            // accountDateTime
            // 
            accountDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountDateTime.Location = new Point(3, 766);
            accountDateTime.MaxDate = new DateTime(2026, 2, 27, 0, 0, 0, 0);
            accountDateTime.Name = "accountDateTime";
            accountDateTime.Size = new Size(431, 27);
            accountDateTime.TabIndex = 50;
            accountDateTime.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // orgCorrAccountTextBox
            // 
            orgCorrAccountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orgCorrAccountTextBox.Location = new Point(3, 713);
            orgCorrAccountTextBox.Mask = "4\\0000000000000000000";
            orgCorrAccountTextBox.Name = "orgCorrAccountTextBox";
            orgCorrAccountTextBox.Size = new Size(431, 27);
            orgCorrAccountTextBox.TabIndex = 49;
            // 
            // bankCorrAccountTextBox
            // 
            bankCorrAccountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankCorrAccountTextBox.Location = new Point(3, 607);
            bankCorrAccountTextBox.Mask = "3\\0100000000000000000";
            bankCorrAccountTextBox.Name = "bankCorrAccountTextBox";
            bankCorrAccountTextBox.Size = new Size(431, 27);
            bankCorrAccountTextBox.TabIndex = 48;
            // 
            // bankInnTextBox
            // 
            bankInnTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankInnTextBox.Location = new Point(3, 660);
            bankInnTextBox.Mask = "0000000000";
            bankInnTextBox.Name = "bankInnTextBox";
            bankInnTextBox.Size = new Size(431, 27);
            bankInnTextBox.TabIndex = 47;
            bankInnTextBox.TextChanged += bankInnTextBox_TextChanged;
            // 
            // bankKppTextBox
            // 
            bankKppTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankKppTextBox.Location = new Point(3, 554);
            bankKppTextBox.Mask = "000000000";
            bankKppTextBox.Name = "bankKppTextBox";
            bankKppTextBox.Size = new Size(431, 27);
            bankKppTextBox.TabIndex = 46;
            bankKppTextBox.TextChanged += bankKppTextBox_TextChanged;
            // 
            // bankBikTextBox
            // 
            bankBikTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankBikTextBox.Location = new Point(3, 501);
            bankBikTextBox.Mask = "000000000";
            bankBikTextBox.Name = "bankBikTextBox";
            bankBikTextBox.Size = new Size(431, 27);
            bankBikTextBox.TabIndex = 45;
            bankBikTextBox.TextChanged += bankBikTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 743);
            label12.Name = "label12";
            label12.Size = new Size(151, 20);
            label12.TabIndex = 43;
            label12.Text = "Дата открытия счета";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 690);
            label14.Name = "label14";
            label14.Size = new Size(180, 20);
            label14.TabIndex = 42;
            label14.Text = "Счет получателя в банке";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 584);
            label11.Name = "label11";
            label11.Size = new Size(228, 20);
            label11.TabIndex = 41;
            label11.Text = "Корреспондентский счет банка";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 637);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 44;
            label13.Text = "ИНН банка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 531);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 40;
            label10.Text = "КПП банка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 478);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 39;
            label9.Text = "БИК банка";
            // 
            // bankNameComboBox
            // 
            bankNameComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankNameComboBox.FormattingEnabled = true;
            bankNameComboBox.Location = new Point(3, 447);
            bankNameComboBox.Name = "bankNameComboBox";
            bankNameComboBox.Size = new Size(431, 28);
            bankNameComboBox.TabIndex = 38;
            bankNameComboBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 424);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 37;
            label8.Text = "Наименование банка";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 371);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 36;
            label7.Text = "ИНН";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 318);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 35;
            label6.Text = "ОГРН";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(3, 288);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(431, 27);
            nameTextBox.TabIndex = 34;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 106);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 33;
            label5.Text = "Повторите пароль";
            // 
            // password2TextBox
            // 
            password2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password2TextBox.Location = new Point(3, 129);
            password2TextBox.MaxLength = 20;
            password2TextBox.Name = "password2TextBox";
            password2TextBox.PasswordChar = '*';
            password2TextBox.Size = new Size(431, 27);
            password2TextBox.TabIndex = 32;
            password2TextBox.TextChanged += password2TextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 265);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 31;
            label4.Text = "Название организации";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(3, 235);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(431, 27);
            emailTextBox.TabIndex = 30;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 212);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(3, 76);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(431, 27);
            passwordTextBox.TabIndex = 28;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 27;
            label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(3, 23);
            loginTextBox.MaxLength = 20;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(431, 27);
            loginTextBox.TabIndex = 26;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 25;
            label1.Text = "Логин";
            // 
            // OrganizerReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            MinimumSize = new Size(500, 500);
            Name = "OrganizerReg";
            Text = "Регистрация организатора";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button okBtn;
        private Button cancelBtn;
        private Panel panel;
        private TextBox innTextBox;
        private MaskedTextBox phoneTextBox;
        private Label label15;
        private DateTimePicker accountDateTime;
        private MaskedTextBox orgCorrAccountTextBox;
        private MaskedTextBox bankCorrAccountTextBox;
        private MaskedTextBox bankInnTextBox;
        private MaskedTextBox bankKppTextBox;
        private MaskedTextBox bankBikTextBox;
        private Label label12;
        private Label label14;
        private Label label11;
        private Label label13;
        private Label label10;
        private Label label9;
        private ComboBox bankNameComboBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox nameTextBox;
        private Label label5;
        private TextBox password2TextBox;
        private Label label4;
        private TextBox emailTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label2;
        private TextBox loginTextBox;
        private Label label1;
        private TextBox ogrnTextBox;
    }
}