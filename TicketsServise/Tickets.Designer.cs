namespace TicketsServise
{
    partial class Tickets
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
            buyBtn = new Button();
            exitBtn = new Button();
            ticketsList = new ListBox();
            addTicketBtn = new Button();
            cartList = new ListBox();
            delTicketBtn = new Button();
            sumLabel = new Label();
            SuspendLayout();
            // 
            // buyBtn
            // 
            buyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buyBtn.Location = new Point(676, 507);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(94, 29);
            buyBtn.TabIndex = 1;
            buyBtn.Text = "Купить";
            buyBtn.UseVisualStyleBackColor = true;
            buyBtn.Click += buyBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitBtn.Location = new Point(576, 507);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Выход";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // ticketsList
            // 
            ticketsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ticketsList.FormattingEnabled = true;
            ticketsList.Location = new Point(12, 12);
            ticketsList.Name = "ticketsList";
            ticketsList.Size = new Size(558, 524);
            ticketsList.TabIndex = 3;
            // 
            // addTicketBtn
            // 
            addTicketBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addTicketBtn.Location = new Point(576, 437);
            addTicketBtn.Name = "addTicketBtn";
            addTicketBtn.Size = new Size(194, 29);
            addTicketBtn.TabIndex = 4;
            addTicketBtn.Text = "Добавить в корзину";
            addTicketBtn.UseVisualStyleBackColor = true;
            addTicketBtn.Click += addTicketBtn_Click;
            // 
            // cartList
            // 
            cartList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cartList.FormattingEnabled = true;
            cartList.Location = new Point(576, 12);
            cartList.Name = "cartList";
            cartList.SelectionMode = SelectionMode.None;
            cartList.Size = new Size(194, 384);
            cartList.TabIndex = 5;
            // 
            // delTicketBtn
            // 
            delTicketBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delTicketBtn.Location = new Point(576, 472);
            delTicketBtn.Name = "delTicketBtn";
            delTicketBtn.Size = new Size(194, 29);
            delTicketBtn.TabIndex = 6;
            delTicketBtn.Text = "Удалить из корзины";
            delTicketBtn.UseVisualStyleBackColor = true;
            // 
            // sumLabel
            // 
            sumLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sumLabel.Location = new Point(576, 399);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(194, 35);
            sumLabel.TabIndex = 7;
            sumLabel.Text = "Сумма: 0 рублей";
            sumLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // Tickets
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(sumLabel);
            Controls.Add(delTicketBtn);
            Controls.Add(cartList);
            Controls.Add(addTicketBtn);
            Controls.Add(ticketsList);
            Controls.Add(exitBtn);
            Controls.Add(buyBtn);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Tickets";
            Text = "Билеты";
            ResumeLayout(false);
        }

        #endregion
        private Button buyBtn;
        private Button exitBtn;
        private ListBox ticketsList;
        private Button addTicketBtn;
        private ListBox cartList;
        private Button delTicketBtn;
        private Label sumLabel;
    }
}