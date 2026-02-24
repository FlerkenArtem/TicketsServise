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
            label1 = new Label();
            loginTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            label4 = new Label();
            password2TextBox = new TextBox();
            label5 = new Label();
            nameTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bankNameComboBox = new ComboBox();
            label9 = new Label();
            bankBikTextBox = new MaskedTextBox();
            label10 = new Label();
            bankKppTextBox = new MaskedTextBox();
            label11 = new Label();
            bankCorrAccountTextBox = new MaskedTextBox();
            label12 = new Label();
            accountDateTime = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            bankInnTextBox = new MaskedTextBox();
            orgCorrAccountTextBox = new MaskedTextBox();
            okBtn = new Button();
            cancelBtn = new Button();
            label15 = new Label();
            phoneTextBox = new MaskedTextBox();
            ogrnTextBox = new TextBox();
            innTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(12, 32);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(363, 27);
            loginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(12, 85);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(363, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 221);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(12, 244);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(363, 27);
            emailTextBox.TabIndex = 5;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 6;
            label4.Text = "Название организации";
            // 
            // password2TextBox
            // 
            password2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password2TextBox.Location = new Point(12, 138);
            password2TextBox.Name = "password2TextBox";
            password2TextBox.Size = new Size(363, 27);
            password2TextBox.TabIndex = 7;
            password2TextBox.TextChanged += password2TextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 8;
            label5.Text = "Повторите пароль";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 297);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(363, 27);
            nameTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 327);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 10;
            label6.Text = "ОГРН";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 380);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "ИНН";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 433);
            label8.Name = "label8";
            label8.Size = new Size(161, 20);
            label8.TabIndex = 14;
            label8.Text = "Наименование банка";
            // 
            // bankNameComboBox
            // 
            bankNameComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankNameComboBox.FormattingEnabled = true;
            bankNameComboBox.Location = new Point(12, 456);
            bankNameComboBox.Name = "bankNameComboBox";
            bankNameComboBox.Size = new Size(363, 28);
            bankNameComboBox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 487);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 16;
            label9.Text = "БИК банка";
            // 
            // bankBikTextBox
            // 
            bankBikTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankBikTextBox.Location = new Point(12, 510);
            bankBikTextBox.Name = "bankBikTextBox";
            bankBikTextBox.Size = new Size(363, 27);
            bankBikTextBox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 540);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 16;
            label10.Text = "КПП банка";
            // 
            // bankKppTextBox
            // 
            bankKppTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankKppTextBox.Location = new Point(12, 563);
            bankKppTextBox.Name = "bankKppTextBox";
            bankKppTextBox.Size = new Size(363, 27);
            bankKppTextBox.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 593);
            label11.Name = "label11";
            label11.Size = new Size(228, 20);
            label11.TabIndex = 16;
            label11.Text = "Корреспондентский счет банка";
            // 
            // bankCorrAccountTextBox
            // 
            bankCorrAccountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankCorrAccountTextBox.Location = new Point(12, 616);
            bankCorrAccountTextBox.Name = "bankCorrAccountTextBox";
            bankCorrAccountTextBox.Size = new Size(363, 27);
            bankCorrAccountTextBox.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 752);
            label12.Name = "label12";
            label12.Size = new Size(151, 20);
            label12.TabIndex = 16;
            label12.Text = "Дата открытия счета";
            // 
            // accountDateTime
            // 
            accountDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountDateTime.Location = new Point(12, 775);
            accountDateTime.Name = "accountDateTime";
            accountDateTime.Size = new Size(363, 27);
            accountDateTime.TabIndex = 18;
            accountDateTime.Value = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 646);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 16;
            label13.Text = "ИНН банка";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 699);
            label14.Name = "label14";
            label14.Size = new Size(180, 20);
            label14.TabIndex = 16;
            label14.Text = "Счет получателя в банке";
            // 
            // bankInnTextBox
            // 
            bankInnTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bankInnTextBox.Location = new Point(12, 669);
            bankInnTextBox.Name = "bankInnTextBox";
            bankInnTextBox.Size = new Size(363, 27);
            bankInnTextBox.TabIndex = 17;
            // 
            // orgCorrAccountTextBox
            // 
            orgCorrAccountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orgCorrAccountTextBox.Location = new Point(12, 722);
            orgCorrAccountTextBox.Name = "orgCorrAccountTextBox";
            orgCorrAccountTextBox.Size = new Size(363, 27);
            orgCorrAccountTextBox.TabIndex = 17;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(281, 2319);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 19;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(181, 2319);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 168);
            label15.Name = "label15";
            label15.Size = new Size(127, 20);
            label15.TabIndex = 21;
            label15.Text = "Номер телефона";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 191);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(363, 27);
            phoneTextBox.TabIndex = 22;
            phoneTextBox.TextChanged += phoneTextBox_TextChanged;
            // 
            // ogrnTextBox
            // 
            ogrnTextBox.Location = new Point(12, 350);
            ogrnTextBox.Name = "ogrnTextBox";
            ogrnTextBox.Size = new Size(363, 27);
            ogrnTextBox.TabIndex = 23;
            ogrnTextBox.TextChanged += ogrnTextBox_TextChanged;
            // 
            // innTextBox
            // 
            innTextBox.Location = new Point(12, 403);
            innTextBox.Name = "innTextBox";
            innTextBox.Size = new Size(363, 27);
            innTextBox.TabIndex = 24;
            // 
            // OrganizerReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(482, 1021);
            Controls.Add(innTextBox);
            Controls.Add(ogrnTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(label15);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(accountDateTime);
            Controls.Add(orgCorrAccountTextBox);
            Controls.Add(bankCorrAccountTextBox);
            Controls.Add(bankInnTextBox);
            Controls.Add(bankKppTextBox);
            Controls.Add(bankBikTextBox);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(bankNameComboBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(password2TextBox);
            Controls.Add(label4);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            MinimumSize = new Size(500, 500);
            Name = "OrganizerReg";
            Text = "Регистрация организатора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label4;
        private TextBox password2TextBox;
        private Label label5;
        private TextBox nameTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox bankNameComboBox;
        private Label label9;
        private MaskedTextBox bankBikTextBox;
        private Label label10;
        private MaskedTextBox bankKppTextBox;
        private Label label11;
        private MaskedTextBox bankCorrAccountTextBox;
        private Label label12;
        private DateTimePicker accountDateTime;
        private Label label13;
        private Label label14;
        private MaskedTextBox bankInnTextBox;
        private MaskedTextBox orgCorrAccountTextBox;
        private Button okBtn;
        private Button cancelBtn;
        private Label label15;
        private MaskedTextBox phoneTextBox;
        private TextBox ogrnTextBox;
        private TextBox innTextBox;
    }
}