namespace TicketsServise
{
    partial class NewTicketsWON
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
            groupBox = new GroupBox();
            placeNameEdit = new TextBox();
            countEdit = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            priceEdit = new NumericUpDown();
            label2 = new Label();
            eventComboBox = new ComboBox();
            label1 = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)countEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceEdit).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(placeNameEdit);
            groupBox.Controls.Add(countEdit);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Location = new Point(12, 120);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(258, 132);
            groupBox.TabIndex = 13;
            groupBox.TabStop = false;
            groupBox.Text = "Создать места";
            // 
            // placeNameEdit
            // 
            placeNameEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            placeNameEdit.Location = new Point(6, 88);
            placeNameEdit.Name = "placeNameEdit";
            placeNameEdit.Size = new Size(246, 27);
            placeNameEdit.TabIndex = 2;
            // 
            // countEdit
            // 
            countEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countEdit.Location = new Point(112, 26);
            countEdit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            countEdit.Name = "countEdit";
            countEdit.Size = new Size(140, 27);
            countEdit.TabIndex = 1;
            countEdit.ValueChanged += countEdit_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 0;
            label4.Text = "С названием места";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "В количестве";
            // 
            // priceEdit
            // 
            priceEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            priceEdit.DecimalPlaces = 2;
            priceEdit.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceEdit.Location = new Point(12, 87);
            priceEdit.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            priceEdit.Name = "priceEdit";
            priceEdit.Size = new Size(258, 27);
            priceEdit.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 11;
            label2.Text = "Цена за билет";
            // 
            // eventComboBox
            // 
            eventComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eventComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventComboBox.FormattingEnabled = true;
            eventComboBox.Location = new Point(12, 33);
            eventComboBox.Name = "eventComboBox";
            eventComboBox.Size = new Size(258, 28);
            eventComboBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 9;
            label1.Text = "Мероприятие";
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(76, 313);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(176, 313);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 7;
            okBtn.Text = "ОК";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // NewTicketsWON
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(groupBox);
            Controls.Add(priceEdit);
            Controls.Add(label2);
            Controls.Add(eventComboBox);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            MaximumSize = new Size(300, 400);
            MinimumSize = new Size(300, 400);
            Name = "NewTicketsWON";
            Text = "Создать билеты";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)countEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private Label label4;
        private Label label3;
        private NumericUpDown priceEdit;
        private Label label2;
        private ComboBox eventComboBox;
        private Label label1;
        private Button cancelBtn;
        private Button okBtn;
        private TextBox placeNameEdit;
        private NumericUpDown countEdit;
    }
}