namespace TicketsServise
{
    partial class BuyerReg
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
            cancelBtn = new Button();
            okBtn = new Button();
            label2 = new Label();
            surnameTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            patronymicTextBox = new TextBox();
            label5 = new Label();
            emailTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            passwordTextBox = new TextBox();
            label8 = new Label();
            password2TextBox = new TextBox();
            label1 = new Label();
            loginTextBox = new TextBox();
            phoneTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(376, 512);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(276, 512);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 2;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameTextBox.Location = new Point(12, 32);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(458, 27);
            surnameTextBox.TabIndex = 4;
            surnameTextBox.TextChanged += surnameTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 85);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(458, 27);
            nameTextBox.TabIndex = 6;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patronymicTextBox.Location = new Point(12, 138);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.Size = new Size(458, 27);
            patronymicTextBox.TabIndex = 8;
            patronymicTextBox.TextChanged += patronymicTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(12, 191);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(458, 27);
            emailTextBox.TabIndex = 10;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 11;
            label6.Text = "Номер телефона";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 327);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 13;
            label7.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(12, 350);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(458, 27);
            passwordTextBox.TabIndex = 14;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 380);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 13;
            label8.Text = "Повторите пароль";
            // 
            // password2TextBox
            // 
            password2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password2TextBox.Location = new Point(12, 403);
            password2TextBox.MaxLength = 20;
            password2TextBox.Name = "password2TextBox";
            password2TextBox.PasswordChar = '*';
            password2TextBox.Size = new Size(458, 27);
            password2TextBox.TabIndex = 14;
            password2TextBox.TextChanged += password2TextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 15;
            label1.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(12, 297);
            loginTextBox.MaxLength = 20;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(458, 27);
            loginTextBox.TabIndex = 14;
            loginTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTextBox.Location = new Point(12, 244);
            phoneTextBox.Mask = "+7 (000) 000-00-00";
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(458, 27);
            phoneTextBox.TabIndex = 16;
            phoneTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // BuyerReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(phoneTextBox);
            Controls.Add(label1);
            Controls.Add(password2TextBox);
            Controls.Add(loginTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailTextBox);
            Controls.Add(label5);
            Controls.Add(patronymicTextBox);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(surnameTextBox);
            Controls.Add(label2);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(500, 600);
            Name = "BuyerReg";
            Text = "Регистрация покупателя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelBtn;
        private Button okBtn;
        private Label label2;
        private TextBox surnameTextBox;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private TextBox patronymicTextBox;
        private Label label5;
        private TextBox emailTextBox;
        private Label label6;
        private Label label7;
        private TextBox passwordTextBox;
        private Label label8;
        private TextBox password2TextBox;
        private Label label1;
        private TextBox loginTextBox;
        private MaskedTextBox phoneTextBox;
    }
}