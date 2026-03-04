namespace TicketsServise
{
    partial class BuyTicket
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
            paymentTypeComboBox = new ComboBox();
            label1 = new Label();
            cardGroupBox = new GroupBox();
            label2 = new Label();
            cardNumberTextBox = new MaskedTextBox();
            label3 = new Label();
            validThruTextBox = new MaskedTextBox();
            label4 = new Label();
            cvv2TextBox = new MaskedTextBox();
            cardGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(176, 312);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 0;
            okBtn.Text = "Купить";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(76, 312);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // paymentTypeComboBox
            // 
            paymentTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paymentTypeComboBox.FormattingEnabled = true;
            paymentTypeComboBox.Location = new Point(12, 32);
            paymentTypeComboBox.Name = "paymentTypeComboBox";
            paymentTypeComboBox.Size = new Size(258, 28);
            paymentTypeComboBox.TabIndex = 2;
            paymentTypeComboBox.SelectedIndexChanged += paymentTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Способ оплаты";
            // 
            // cardGroupBox
            // 
            cardGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardGroupBox.Controls.Add(cvv2TextBox);
            cardGroupBox.Controls.Add(label4);
            cardGroupBox.Controls.Add(validThruTextBox);
            cardGroupBox.Controls.Add(label3);
            cardGroupBox.Controls.Add(cardNumberTextBox);
            cardGroupBox.Controls.Add(label2);
            cardGroupBox.Enabled = false;
            cardGroupBox.Location = new Point(12, 66);
            cardGroupBox.Name = "cardGroupBox";
            cardGroupBox.Size = new Size(258, 190);
            cardGroupBox.TabIndex = 4;
            cardGroupBox.TabStop = false;
            cardGroupBox.Text = "Данные карты";
            cardGroupBox.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Номер карты";
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardNumberTextBox.Location = new Point(6, 46);
            cardNumberTextBox.Mask = "0000000000000000";
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(246, 27);
            cardNumberTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Срок действия";
            // 
            // validThruTextBox
            // 
            validThruTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            validThruTextBox.Location = new Point(6, 99);
            validThruTextBox.Mask = "00\\/00";
            validThruTextBox.Name = "validThruTextBox";
            validThruTextBox.Size = new Size(246, 27);
            validThruTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "CVV2";
            // 
            // cvv2TextBox
            // 
            cvv2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cvv2TextBox.Location = new Point(6, 152);
            cvv2TextBox.Mask = "000";
            cvv2TextBox.Name = "cvv2TextBox";
            cvv2TextBox.Size = new Size(246, 27);
            cvv2TextBox.TabIndex = 5;
            // 
            // BuyTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(cardGroupBox);
            Controls.Add(label1);
            Controls.Add(paymentTypeComboBox);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "BuyTicket";
            Text = "Купить";
            cardGroupBox.ResumeLayout(false);
            cardGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private Button cancelBtn;
        private ComboBox paymentTypeComboBox;
        private Label label1;
        private GroupBox cardGroupBox;
        private MaskedTextBox cvv2TextBox;
        private Label label4;
        private MaskedTextBox validThruTextBox;
        private Label label3;
        private MaskedTextBox cardNumberTextBox;
        private Label label2;
    }
}