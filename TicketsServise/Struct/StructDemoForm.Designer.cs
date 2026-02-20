namespace TicketsServise.Struct
{
    partial class StructDemoForm
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
            addStructBtn = new Button();
            label2 = new Label();
            editPriceStructBtn = new Button();
            copyStructBtn = new Button();
            addClassBtn = new Button();
            editPriceClassBtn = new Button();
            copyClassBtn = new Button();
            structListBox = new ListBox();
            classListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Структуры";
            // 
            // addStructBtn
            // 
            addStructBtn.Location = new Point(12, 409);
            addStructBtn.Name = "addStructBtn";
            addStructBtn.Size = new Size(94, 29);
            addStructBtn.TabIndex = 2;
            addStructBtn.Text = "Добавить";
            addStructBtn.UseVisualStyleBackColor = true;
            addStructBtn.Click += addStructBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Классы";
            // 
            // editPriceStructBtn
            // 
            editPriceStructBtn.Location = new Point(225, 409);
            editPriceStructBtn.Name = "editPriceStructBtn";
            editPriceStructBtn.Size = new Size(134, 29);
            editPriceStructBtn.TabIndex = 2;
            editPriceStructBtn.Text = "Изменить цену";
            editPriceStructBtn.UseVisualStyleBackColor = true;
            editPriceStructBtn.Click += editPriceStructBtn_Click;
            // 
            // copyStructBtn
            // 
            copyStructBtn.Location = new Point(112, 409);
            copyStructBtn.Name = "copyStructBtn";
            copyStructBtn.Size = new Size(107, 29);
            copyStructBtn.TabIndex = 2;
            copyStructBtn.Text = "Копировать";
            copyStructBtn.UseVisualStyleBackColor = true;
            copyStructBtn.Click += copyStructBtn_Click;
            // 
            // addClassBtn
            // 
            addClassBtn.Location = new Point(403, 409);
            addClassBtn.Name = "addClassBtn";
            addClassBtn.Size = new Size(94, 29);
            addClassBtn.TabIndex = 2;
            addClassBtn.Text = "Добавить";
            addClassBtn.UseVisualStyleBackColor = true;
            addClassBtn.Click += addClassBtn_Click;
            // 
            // editPriceClassBtn
            // 
            editPriceClassBtn.Location = new Point(616, 409);
            editPriceClassBtn.Name = "editPriceClassBtn";
            editPriceClassBtn.Size = new Size(134, 29);
            editPriceClassBtn.TabIndex = 2;
            editPriceClassBtn.Text = "Изменить цену";
            editPriceClassBtn.UseVisualStyleBackColor = true;
            editPriceClassBtn.Click += editPriceClassBtn_Click;
            // 
            // copyClassBtn
            // 
            copyClassBtn.Location = new Point(503, 409);
            copyClassBtn.Name = "copyClassBtn";
            copyClassBtn.Size = new Size(107, 29);
            copyClassBtn.TabIndex = 2;
            copyClassBtn.Text = "Копировать";
            copyClassBtn.UseVisualStyleBackColor = true;
            copyClassBtn.Click += copyClassBtn_Click;
            // 
            // structListBox
            // 
            structListBox.FormattingEnabled = true;
            structListBox.Location = new Point(12, 32);
            structListBox.Name = "structListBox";
            structListBox.Size = new Size(385, 364);
            structListBox.TabIndex = 3;
            // 
            // classListBox
            // 
            classListBox.FormattingEnabled = true;
            classListBox.Location = new Point(403, 32);
            classListBox.Name = "classListBox";
            classListBox.Size = new Size(385, 364);
            classListBox.TabIndex = 4;
            // 
            // StructDemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classListBox);
            Controls.Add(structListBox);
            Controls.Add(copyClassBtn);
            Controls.Add(copyStructBtn);
            Controls.Add(editPriceClassBtn);
            Controls.Add(editPriceStructBtn);
            Controls.Add(addClassBtn);
            Controls.Add(addStructBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StructDemoForm";
            Text = "StructDemoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addStructBtn;
        private Label label2;
        private Button editPriceStructBtn;
        private Button copyStructBtn;
        private Button addClassBtn;
        private Button editPriceClassBtn;
        private Button copyClassBtn;
        private ListBox structListBox;
        private ListBox classListBox;
    }
}