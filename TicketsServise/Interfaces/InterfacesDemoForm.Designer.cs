namespace TicketsServise.Interfaces
{
    partial class InterfacesDemoForm
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
            btnCreate = new Button();
            btnSortComparable = new Button();
            btnSortComparer = new Button();
            btnForeach = new Button();
            btnClone = new Button();
            btnDispose = new Button();
            listBoxCollections = new ListBox();
            listBoxLog = new ListBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSortComparable
            // 
            btnSortComparable.Location = new Point(112, 12);
            btnSortComparable.Name = "btnSortComparable";
            btnSortComparable.Size = new Size(205, 29);
            btnSortComparable.TabIndex = 1;
            btnSortComparable.Text = "Сортировка IComparable";
            btnSortComparable.UseVisualStyleBackColor = true;
            btnSortComparable.Click += btnSortComparable_Click;
            // 
            // btnSortComparer
            // 
            btnSortComparer.Location = new Point(323, 12);
            btnSortComparer.Name = "btnSortComparer";
            btnSortComparer.Size = new Size(179, 29);
            btnSortComparer.TabIndex = 2;
            btnSortComparer.Text = "Сортировка IComparer";
            btnSortComparer.UseVisualStyleBackColor = true;
            btnSortComparer.Click += btnSortComparer_Click;
            // 
            // btnForeach
            // 
            btnForeach.Location = new Point(12, 47);
            btnForeach.Name = "btnForeach";
            btnForeach.Size = new Size(139, 29);
            btnForeach.TabIndex = 3;
            btnForeach.Text = "Перебор Foreach";
            btnForeach.UseVisualStyleBackColor = true;
            btnForeach.Click += btnForeach_Click;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(157, 47);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(130, 29);
            btnClone.TabIndex = 4;
            btnClone.Text = "Клонирование";
            btnClone.UseVisualStyleBackColor = true;
            btnClone.Click += btnClone_Click;
            // 
            // btnDispose
            // 
            btnDispose.Location = new Point(293, 47);
            btnDispose.Name = "btnDispose";
            btnDispose.Size = new Size(209, 29);
            btnDispose.TabIndex = 5;
            btnDispose.Text = "Освобождение ресурсов";
            btnDispose.UseVisualStyleBackColor = true;
            btnDispose.Click += btnDispose_Click;
            // 
            // listBoxCollections
            // 
            listBoxCollections.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCollections.FormattingEnabled = true;
            listBoxCollections.Location = new Point(12, 82);
            listBoxCollections.Name = "listBoxCollections";
            listBoxCollections.Size = new Size(758, 224);
            listBoxCollections.TabIndex = 6;
            // 
            // listBoxLog
            // 
            listBoxLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxLog.FormattingEnabled = true;
            listBoxLog.Location = new Point(12, 312);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(758, 224);
            listBoxLog.TabIndex = 7;
            // 
            // InterfacesDemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(listBoxLog);
            Controls.Add(listBoxCollections);
            Controls.Add(btnDispose);
            Controls.Add(btnClone);
            Controls.Add(btnForeach);
            Controls.Add(btnSortComparer);
            Controls.Add(btnSortComparable);
            Controls.Add(btnCreate);
            Name = "InterfacesDemoForm";
            Text = "InterfacesDemoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnSortComparable;
        private Button btnSortComparer;
        private Button btnForeach;
        private Button btnClone;
        private Button btnDispose;
        private ListBox listBoxCollections;
        private ListBox listBoxLog;
    }
}