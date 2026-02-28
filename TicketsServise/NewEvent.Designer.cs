namespace TicketsServise
{
    partial class NewEvent
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
            Button addBtn;
            okBtn = new Button();
            cancelBtn = new Button();
            panel = new Panel();
            penformersGroupBox = new GroupBox();
            performersListBox = new ListBox();
            delBtn = new Button();
            performerInfoTextBox = new TextBox();
            label7 = new Label();
            performerTextBox = new TextBox();
            label6 = new Label();
            genreComboBox = new ComboBox();
            typeComboBox = new ComboBox();
            placeComboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimeTextBox = new MaskedTextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            addBtn = new Button();
            panel.SuspendLayout();
            penformersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addBtn.Location = new Point(6, 301);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 3;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Location = new Point(376, 412);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Location = new Point(276, 412);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.Controls.Add(penformersGroupBox);
            panel.Controls.Add(genreComboBox);
            panel.Controls.Add(typeComboBox);
            panel.Controls.Add(placeComboBox);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(dateTimeTextBox);
            panel.Controls.Add(label2);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(label1);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(458, 394);
            panel.TabIndex = 2;
            // 
            // penformersGroupBox
            // 
            penformersGroupBox.Controls.Add(performersListBox);
            penformersGroupBox.Controls.Add(delBtn);
            penformersGroupBox.Controls.Add(performerInfoTextBox);
            penformersGroupBox.Controls.Add(label7);
            penformersGroupBox.Controls.Add(addBtn);
            penformersGroupBox.Controls.Add(performerTextBox);
            penformersGroupBox.Controls.Add(label6);
            penformersGroupBox.Location = new Point(3, 271);
            penformersGroupBox.Name = "penformersGroupBox";
            penformersGroupBox.Size = new Size(428, 349);
            penformersGroupBox.TabIndex = 6;
            penformersGroupBox.TabStop = false;
            penformersGroupBox.Text = "Исполнители";
            // 
            // performersListBox
            // 
            performersListBox.FormattingEnabled = true;
            performersListBox.Location = new Point(206, 26);
            performersListBox.Name = "performersListBox";
            performersListBox.Size = new Size(216, 304);
            performersListBox.TabIndex = 7;
            // 
            // delBtn
            // 
            delBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            delBtn.Location = new Point(106, 301);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 6;
            delBtn.Text = " Удалить";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // performerInfoTextBox
            // 
            performerInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            performerInfoTextBox.Location = new Point(6, 99);
            performerInfoTextBox.Multiline = true;
            performerInfoTextBox.Name = "performerInfoTextBox";
            performerInfoTextBox.ScrollBars = ScrollBars.Vertical;
            performerInfoTextBox.Size = new Size(194, 196);
            performerInfoTextBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 76);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 4;
            label7.Text = "Информация";
            // 
            // performerTextBox
            // 
            performerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            performerTextBox.Location = new Point(6, 46);
            performerTextBox.Name = "performerTextBox";
            performerTextBox.Size = new Size(194, 27);
            performerTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 1;
            label6.Text = "Исполнитель";
            // 
            // genreComboBox
            // 
            genreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(3, 237);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(428, 28);
            genreComboBox.Sorted = true;
            genreComboBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(3, 183);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(428, 28);
            typeComboBox.Sorted = true;
            typeComboBox.TabIndex = 5;
            // 
            // placeComboBox
            // 
            placeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            placeComboBox.FormattingEnabled = true;
            placeComboBox.Location = new Point(3, 129);
            placeComboBox.Name = "placeComboBox";
            placeComboBox.Size = new Size(428, 28);
            placeComboBox.Sorted = true;
            placeComboBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 214);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 4;
            label4.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Площадка";
            // 
            // dateTimeTextBox
            // 
            dateTimeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeTextBox.Location = new Point(3, 76);
            dateTimeTextBox.Mask = "00/00/0000 90:00";
            dateTimeTextBox.Name = "dateTimeTextBox";
            dateTimeTextBox.Size = new Size(428, 27);
            dateTimeTextBox.TabIndex = 3;
            dateTimeTextBox.ValidatingType = typeof(DateTime);
            dateTimeTextBox.TextChanged += dateTimeTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Дата и время";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(3, 23);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(428, 27);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Название мероприятия";
            // 
            // NewEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "NewEvent";
            Text = "Добавить мероприятие";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            penformersGroupBox.ResumeLayout(false);
            penformersGroupBox.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button okBtn;
        private Button cancelBtn;
        private Panel panel;
        private GroupBox penformersGroupBox;
        private ComboBox genreComboBox;
        private ComboBox typeComboBox;
        private ComboBox placeComboBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox dateTimeTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox performerInfoTextBox;
        private Label label7;
        private TextBox performerTextBox;
        private Label label6;
        private Button delBtn;
        private ListBox performersListBox;
    }
}