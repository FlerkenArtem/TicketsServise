namespace TicketsServise
{
    partial class NewTicketsWN
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
            label1 = new Label();
            eventComboBox = new ComboBox();
            label2 = new Label();
            priceEdit = new NumericUpDown();
            groupBox = new GroupBox();
            placeToEdit = new NumericUpDown();
            placeFromEdit = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)priceEdit).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)placeToEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)placeFromEdit).BeginInit();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(176, 312);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 0;
            okBtn.Text = "ОК";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "Мероприятие";
            // 
            // eventComboBox
            // 
            eventComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eventComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventComboBox.FormattingEnabled = true;
            eventComboBox.Location = new Point(12, 32);
            eventComboBox.Name = "eventComboBox";
            eventComboBox.Size = new Size(258, 28);
            eventComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "Цена за билет";
            // 
            // priceEdit
            // 
            priceEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            priceEdit.DecimalPlaces = 2;
            priceEdit.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceEdit.Location = new Point(12, 86);
            priceEdit.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            priceEdit.Name = "priceEdit";
            priceEdit.Size = new Size(258, 27);
            priceEdit.TabIndex = 5;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(placeToEdit);
            groupBox.Controls.Add(placeFromEdit);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Location = new Point(12, 119);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(258, 102);
            groupBox.TabIndex = 6;
            groupBox.TabStop = false;
            groupBox.Text = "Создать места";
            // 
            // placeToEdit
            // 
            placeToEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            placeToEdit.Location = new Point(41, 63);
            placeToEdit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            placeToEdit.Name = "placeToEdit";
            placeToEdit.Size = new Size(211, 27);
            placeToEdit.TabIndex = 1;
            placeToEdit.ValueChanged += placeEdits_ValueChanged;
            // 
            // placeFromEdit
            // 
            placeFromEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            placeFromEdit.Location = new Point(41, 26);
            placeFromEdit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            placeFromEdit.Name = "placeFromEdit";
            placeFromEdit.Size = new Size(211, 27);
            placeFromEdit.TabIndex = 1;
            placeFromEdit.ValueChanged += placeEdits_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 0;
            label4.Text = "По";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 0;
            label3.Text = "С";
            // 
            // NewTicketsWN
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
            Name = "NewTicketsWN";
            Text = "Создать билеты";
            ((System.ComponentModel.ISupportInitialize)priceEdit).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)placeToEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)placeFromEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private Button cancelBtn;
        private Label label1;
        private ComboBox eventComboBox;
        private Label label2;
        private NumericUpDown priceEdit;
        private GroupBox groupBox;
        private NumericUpDown placeToEdit;
        private NumericUpDown placeFromEdit;
        private Label label4;
        private Label label3;
    }
}