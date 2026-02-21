namespace TicketsServise.Generics
{
    partial class GenericsDemoForm
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
            tabControl = new TabControl();
            listPage = new TabPage();
            listDateTimePicker = new DateTimePicker();
            nameListTextBox = new TextBox();
            priceListNumeric = new NumericUpDown();
            idListNumeric = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            addListBtn = new Button();
            delListBtn = new Button();
            findListBtn = new Button();
            listDataGridView = new DataGridView();
            dictPage = new TabPage();
            dictDateTimePicker = new DateTimePicker();
            nameDictTextBox = new TextBox();
            priceDictNumeric = new NumericUpDown();
            idDictNumeric = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            addDictBtn = new Button();
            delDictBtn = new Button();
            findDictBtn = new Button();
            dictDataGridView = new DataGridView();
            queuePage = new TabPage();
            queueListBox = new ListBox();
            enqueueBtn = new Button();
            dequeueBtn = new Button();
            peekQueueBtn = new Button();
            stackPage = new TabPage();
            stackListBox = new ListBox();
            pushBtn = new Button();
            popBtn = new Button();
            peekStackBtn = new Button();
            arrayListHashtablePage = new TabPage();
            hashtableBtn = new Button();
            arrayListBtn = new Button();
            arrayListHashtableListBox = new ListBox();
            dateQueue = new DateTimePicker();
            nameQueue = new TextBox();
            priceQueue = new NumericUpDown();
            idQueue = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dateStack = new DateTimePicker();
            nameStack = new TextBox();
            priceStack = new NumericUpDown();
            idStack = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tabControl.SuspendLayout();
            listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceListNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idListNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            dictPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceDictNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idDictNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dictDataGridView).BeginInit();
            queuePage.SuspendLayout();
            stackPage.SuspendLayout();
            arrayListHashtablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idQueue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceStack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idStack).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(listPage);
            tabControl.Controls.Add(dictPage);
            tabControl.Controls.Add(queuePage);
            tabControl.Controls.Add(stackPage);
            tabControl.Controls.Add(arrayListHashtablePage);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 426);
            tabControl.TabIndex = 0;
            // 
            // listPage
            // 
            listPage.Controls.Add(listDateTimePicker);
            listPage.Controls.Add(nameListTextBox);
            listPage.Controls.Add(priceListNumeric);
            listPage.Controls.Add(idListNumeric);
            listPage.Controls.Add(label2);
            listPage.Controls.Add(label4);
            listPage.Controls.Add(label3);
            listPage.Controls.Add(label1);
            listPage.Controls.Add(addListBtn);
            listPage.Controls.Add(delListBtn);
            listPage.Controls.Add(findListBtn);
            listPage.Controls.Add(listDataGridView);
            listPage.Location = new Point(4, 29);
            listPage.Name = "listPage";
            listPage.Padding = new Padding(3);
            listPage.Size = new Size(768, 393);
            listPage.TabIndex = 0;
            listPage.Text = "List<T>";
            listPage.UseVisualStyleBackColor = true;
            // 
            // listDateTimePicker
            // 
            listDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listDateTimePicker.Location = new Point(615, 189);
            listDateTimePicker.Name = "listDateTimePicker";
            listDateTimePicker.Size = new Size(150, 27);
            listDateTimePicker.TabIndex = 7;
            // 
            // nameListTextBox
            // 
            nameListTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameListTextBox.Location = new Point(615, 80);
            nameListTextBox.Name = "nameListTextBox";
            nameListTextBox.Size = new Size(150, 27);
            nameListTextBox.TabIndex = 6;
            // 
            // priceListNumeric
            // 
            priceListNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceListNumeric.DecimalPlaces = 2;
            priceListNumeric.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceListNumeric.Location = new Point(615, 136);
            priceListNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceListNumeric.Name = "priceListNumeric";
            priceListNumeric.Size = new Size(150, 27);
            priceListNumeric.TabIndex = 5;
            priceListNumeric.ThousandsSeparator = true;
            // 
            // idListNumeric
            // 
            idListNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idListNumeric.Location = new Point(615, 29);
            idListNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idListNumeric.Name = "idListNumeric";
            idListNumeric.Size = new Size(150, 27);
            idListNumeric.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(615, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Название";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(615, 166);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 2;
            label4.Text = "Дата";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(615, 110);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(615, 3);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // addListBtn
            // 
            addListBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addListBtn.Location = new Point(615, 288);
            addListBtn.Name = "addListBtn";
            addListBtn.Size = new Size(147, 29);
            addListBtn.TabIndex = 1;
            addListBtn.Text = "Добавить";
            addListBtn.UseVisualStyleBackColor = true;
            addListBtn.Click += addListBtn_Click;
            // 
            // delListBtn
            // 
            delListBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delListBtn.Location = new Point(615, 323);
            delListBtn.Name = "delListBtn";
            delListBtn.Size = new Size(147, 29);
            delListBtn.TabIndex = 1;
            delListBtn.Text = "Удалить";
            delListBtn.UseVisualStyleBackColor = true;
            delListBtn.Click += delListBtn_Click;
            // 
            // findListBtn
            // 
            findListBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            findListBtn.Location = new Point(615, 358);
            findListBtn.Name = "findListBtn";
            findListBtn.Size = new Size(147, 29);
            findListBtn.TabIndex = 1;
            findListBtn.Text = "Найти";
            findListBtn.UseVisualStyleBackColor = true;
            findListBtn.Click += findListBtn_Click;
            // 
            // listDataGridView
            // 
            listDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listDataGridView.Location = new Point(6, 6);
            listDataGridView.Name = "listDataGridView";
            listDataGridView.RowHeadersWidth = 51;
            listDataGridView.Size = new Size(603, 381);
            listDataGridView.TabIndex = 0;
            // 
            // dictPage
            // 
            dictPage.Controls.Add(dictDateTimePicker);
            dictPage.Controls.Add(nameDictTextBox);
            dictPage.Controls.Add(priceDictNumeric);
            dictPage.Controls.Add(idDictNumeric);
            dictPage.Controls.Add(label5);
            dictPage.Controls.Add(label6);
            dictPage.Controls.Add(label7);
            dictPage.Controls.Add(label8);
            dictPage.Controls.Add(addDictBtn);
            dictPage.Controls.Add(delDictBtn);
            dictPage.Controls.Add(findDictBtn);
            dictPage.Controls.Add(dictDataGridView);
            dictPage.Location = new Point(4, 29);
            dictPage.Name = "dictPage";
            dictPage.Size = new Size(768, 393);
            dictPage.TabIndex = 1;
            dictPage.Text = "Dictionary<int,Ticket>";
            dictPage.UseVisualStyleBackColor = true;
            // 
            // dictDateTimePicker
            // 
            dictDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dictDateTimePicker.Location = new Point(614, 190);
            dictDateTimePicker.Name = "dictDateTimePicker";
            dictDateTimePicker.Size = new Size(150, 27);
            dictDateTimePicker.TabIndex = 19;
            // 
            // nameDictTextBox
            // 
            nameDictTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameDictTextBox.Location = new Point(614, 81);
            nameDictTextBox.Name = "nameDictTextBox";
            nameDictTextBox.Size = new Size(150, 27);
            nameDictTextBox.TabIndex = 18;
            // 
            // priceDictNumeric
            // 
            priceDictNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceDictNumeric.DecimalPlaces = 2;
            priceDictNumeric.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceDictNumeric.Location = new Point(614, 137);
            priceDictNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceDictNumeric.Name = "priceDictNumeric";
            priceDictNumeric.Size = new Size(150, 27);
            priceDictNumeric.TabIndex = 16;
            priceDictNumeric.ThousandsSeparator = true;
            // 
            // idDictNumeric
            // 
            idDictNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idDictNumeric.Location = new Point(614, 30);
            idDictNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idDictNumeric.Name = "idDictNumeric";
            idDictNumeric.Size = new Size(150, 27);
            idDictNumeric.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(614, 60);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 15;
            label5.Text = "Название";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(614, 167);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 12;
            label6.Text = "Дата";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(614, 111);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 13;
            label7.Text = "Цена";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(614, 4);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 14;
            label8.Text = "ID";
            // 
            // addDictBtn
            // 
            addDictBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addDictBtn.Location = new Point(614, 289);
            addDictBtn.Name = "addDictBtn";
            addDictBtn.Size = new Size(147, 29);
            addDictBtn.TabIndex = 9;
            addDictBtn.Text = "Добавить";
            addDictBtn.UseVisualStyleBackColor = true;
            addDictBtn.Click += addDictBtn_Click;
            // 
            // delDictBtn
            // 
            delDictBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delDictBtn.Location = new Point(614, 324);
            delDictBtn.Name = "delDictBtn";
            delDictBtn.Size = new Size(147, 29);
            delDictBtn.TabIndex = 10;
            delDictBtn.Text = "Удалить";
            delDictBtn.UseVisualStyleBackColor = true;
            delDictBtn.Click += delDictBtn_Click;
            // 
            // findDictBtn
            // 
            findDictBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            findDictBtn.Location = new Point(614, 359);
            findDictBtn.Name = "findDictBtn";
            findDictBtn.Size = new Size(147, 29);
            findDictBtn.TabIndex = 11;
            findDictBtn.Text = "Найти";
            findDictBtn.UseVisualStyleBackColor = true;
            findDictBtn.Click += findDictBtn_Click;
            // 
            // dictDataGridView
            // 
            dictDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dictDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dictDataGridView.Location = new Point(5, 7);
            dictDataGridView.Name = "dictDataGridView";
            dictDataGridView.RowHeadersWidth = 51;
            dictDataGridView.Size = new Size(603, 381);
            dictDataGridView.TabIndex = 8;
            // 
            // queuePage
            // 
            queuePage.Controls.Add(dateQueue);
            queuePage.Controls.Add(nameQueue);
            queuePage.Controls.Add(priceQueue);
            queuePage.Controls.Add(idQueue);
            queuePage.Controls.Add(label9);
            queuePage.Controls.Add(label10);
            queuePage.Controls.Add(label11);
            queuePage.Controls.Add(label12);
            queuePage.Controls.Add(queueListBox);
            queuePage.Controls.Add(enqueueBtn);
            queuePage.Controls.Add(dequeueBtn);
            queuePage.Controls.Add(peekQueueBtn);
            queuePage.Location = new Point(4, 29);
            queuePage.Name = "queuePage";
            queuePage.Size = new Size(768, 393);
            queuePage.TabIndex = 2;
            queuePage.Text = "Queue<T>";
            queuePage.UseVisualStyleBackColor = true;
            // 
            // queueListBox
            // 
            queueListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            queueListBox.FormattingEnabled = true;
            queueListBox.Location = new Point(3, 3);
            queueListBox.Name = "queueListBox";
            queueListBox.Size = new Size(589, 384);
            queueListBox.TabIndex = 3;
            // 
            // enqueueBtn
            // 
            enqueueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            enqueueBtn.Location = new Point(598, 291);
            enqueueBtn.Name = "enqueueBtn";
            enqueueBtn.Size = new Size(167, 29);
            enqueueBtn.TabIndex = 2;
            enqueueBtn.Text = "Добавить";
            enqueueBtn.UseVisualStyleBackColor = true;
            enqueueBtn.Click += enqueueBtn_Click;
            // 
            // dequeueBtn
            // 
            dequeueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dequeueBtn.Location = new Point(598, 326);
            dequeueBtn.Name = "dequeueBtn";
            dequeueBtn.Size = new Size(167, 29);
            dequeueBtn.TabIndex = 1;
            dequeueBtn.Text = "Удалить первый";
            dequeueBtn.UseVisualStyleBackColor = true;
            dequeueBtn.Click += dequeueBtn_Click;
            // 
            // peekQueueBtn
            // 
            peekQueueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            peekQueueBtn.Location = new Point(598, 361);
            peekQueueBtn.Name = "peekQueueBtn";
            peekQueueBtn.Size = new Size(167, 29);
            peekQueueBtn.TabIndex = 0;
            peekQueueBtn.Text = "Посмотреть первый";
            peekQueueBtn.UseVisualStyleBackColor = true;
            peekQueueBtn.Click += peekQueueBtn_Click;
            // 
            // stackPage
            // 
            stackPage.Controls.Add(dateStack);
            stackPage.Controls.Add(nameStack);
            stackPage.Controls.Add(priceStack);
            stackPage.Controls.Add(idStack);
            stackPage.Controls.Add(label13);
            stackPage.Controls.Add(label14);
            stackPage.Controls.Add(label15);
            stackPage.Controls.Add(label16);
            stackPage.Controls.Add(stackListBox);
            stackPage.Controls.Add(pushBtn);
            stackPage.Controls.Add(popBtn);
            stackPage.Controls.Add(peekStackBtn);
            stackPage.Location = new Point(4, 29);
            stackPage.Name = "stackPage";
            stackPage.Size = new Size(768, 393);
            stackPage.TabIndex = 3;
            stackPage.Text = "Stack<T>";
            stackPage.UseVisualStyleBackColor = true;
            // 
            // stackListBox
            // 
            stackListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stackListBox.FormattingEnabled = true;
            stackListBox.Location = new Point(3, 3);
            stackListBox.Name = "stackListBox";
            stackListBox.Size = new Size(589, 384);
            stackListBox.TabIndex = 7;
            // 
            // pushBtn
            // 
            pushBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pushBtn.Location = new Point(598, 291);
            pushBtn.Name = "pushBtn";
            pushBtn.Size = new Size(167, 29);
            pushBtn.TabIndex = 6;
            pushBtn.Text = "Добавить";
            pushBtn.UseVisualStyleBackColor = true;
            pushBtn.Click += pushBtn_Click;
            // 
            // popBtn
            // 
            popBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            popBtn.Location = new Point(598, 326);
            popBtn.Name = "popBtn";
            popBtn.Size = new Size(167, 29);
            popBtn.TabIndex = 5;
            popBtn.Text = "Удалить последний";
            popBtn.UseVisualStyleBackColor = true;
            popBtn.Click += popBtn_Click;
            // 
            // peekStackBtn
            // 
            peekStackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            peekStackBtn.Location = new Point(598, 361);
            peekStackBtn.Name = "peekStackBtn";
            peekStackBtn.Size = new Size(167, 29);
            peekStackBtn.TabIndex = 4;
            peekStackBtn.Text = "Посмотреть верхний";
            peekStackBtn.UseVisualStyleBackColor = true;
            peekStackBtn.Click += peekStackBtn_Click;
            // 
            // arrayListHashtablePage
            // 
            arrayListHashtablePage.Controls.Add(hashtableBtn);
            arrayListHashtablePage.Controls.Add(arrayListBtn);
            arrayListHashtablePage.Controls.Add(arrayListHashtableListBox);
            arrayListHashtablePage.Location = new Point(4, 29);
            arrayListHashtablePage.Name = "arrayListHashtablePage";
            arrayListHashtablePage.Size = new Size(768, 393);
            arrayListHashtablePage.TabIndex = 4;
            arrayListHashtablePage.Text = "ArrayList/Hashtable";
            arrayListHashtablePage.UseVisualStyleBackColor = true;
            // 
            // hashtableBtn
            // 
            hashtableBtn.Location = new Point(671, 361);
            hashtableBtn.Name = "hashtableBtn";
            hashtableBtn.Size = new Size(94, 29);
            hashtableBtn.TabIndex = 2;
            hashtableBtn.Text = "Hashtable";
            hashtableBtn.UseVisualStyleBackColor = true;
            hashtableBtn.Click += hashtableBtn_Click;
            // 
            // arrayListBtn
            // 
            arrayListBtn.Location = new Point(571, 361);
            arrayListBtn.Name = "arrayListBtn";
            arrayListBtn.Size = new Size(94, 29);
            arrayListBtn.TabIndex = 1;
            arrayListBtn.Text = "ArrayList";
            arrayListBtn.UseVisualStyleBackColor = true;
            arrayListBtn.Click += arrayListBtn_Click;
            // 
            // arrayListHashtableListBox
            // 
            arrayListHashtableListBox.FormattingEnabled = true;
            arrayListHashtableListBox.Location = new Point(3, 3);
            arrayListHashtableListBox.Name = "arrayListHashtableListBox";
            arrayListHashtableListBox.Size = new Size(762, 344);
            arrayListHashtableListBox.TabIndex = 0;
            // 
            // dateQueue
            // 
            dateQueue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateQueue.Location = new Point(598, 189);
            dateQueue.Name = "dateQueue";
            dateQueue.Size = new Size(167, 27);
            dateQueue.TabIndex = 15;
            // 
            // nameQueue
            // 
            nameQueue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameQueue.Location = new Point(598, 80);
            nameQueue.Name = "nameQueue";
            nameQueue.Size = new Size(167, 27);
            nameQueue.TabIndex = 14;
            // 
            // priceQueue
            // 
            priceQueue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceQueue.DecimalPlaces = 2;
            priceQueue.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceQueue.Location = new Point(598, 136);
            priceQueue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceQueue.Name = "priceQueue";
            priceQueue.Size = new Size(167, 27);
            priceQueue.TabIndex = 12;
            priceQueue.ThousandsSeparator = true;
            // 
            // idQueue
            // 
            idQueue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idQueue.Location = new Point(598, 29);
            idQueue.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idQueue.Name = "idQueue";
            idQueue.Size = new Size(167, 27);
            idQueue.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(598, 59);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 11;
            label9.Text = "Название";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(598, 166);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 8;
            label10.Text = "Дата";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(598, 110);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 9;
            label11.Text = "Цена";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(598, 3);
            label12.Name = "label12";
            label12.Size = new Size(24, 20);
            label12.TabIndex = 10;
            label12.Text = "ID";
            // 
            // dateStack
            // 
            dateStack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateStack.Location = new Point(598, 189);
            dateStack.Name = "dateStack";
            dateStack.Size = new Size(167, 27);
            dateStack.TabIndex = 15;
            // 
            // nameStack
            // 
            nameStack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameStack.Location = new Point(598, 80);
            nameStack.Name = "nameStack";
            nameStack.Size = new Size(167, 27);
            nameStack.TabIndex = 14;
            // 
            // priceStack
            // 
            priceStack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceStack.DecimalPlaces = 2;
            priceStack.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceStack.Location = new Point(598, 136);
            priceStack.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceStack.Name = "priceStack";
            priceStack.Size = new Size(167, 27);
            priceStack.TabIndex = 12;
            priceStack.ThousandsSeparator = true;
            // 
            // idStack
            // 
            idStack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idStack.Location = new Point(598, 29);
            idStack.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idStack.Name = "idStack";
            idStack.Size = new Size(167, 27);
            idStack.TabIndex = 13;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(598, 59);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 11;
            label13.Text = "Название";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(598, 166);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 8;
            label14.Text = "Дата";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(598, 110);
            label15.Name = "label15";
            label15.Size = new Size(45, 20);
            label15.TabIndex = 9;
            label15.Text = "Цена";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(598, 3);
            label16.Name = "label16";
            label16.Size = new Size(24, 20);
            label16.TabIndex = 10;
            label16.Text = "ID";
            // 
            // GenericsDemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "GenericsDemoForm";
            Text = "GenericsDemoForm";
            tabControl.ResumeLayout(false);
            listPage.ResumeLayout(false);
            listPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceListNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)idListNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            dictPage.ResumeLayout(false);
            dictPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceDictNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)idDictNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dictDataGridView).EndInit();
            queuePage.ResumeLayout(false);
            queuePage.PerformLayout();
            stackPage.ResumeLayout(false);
            stackPage.PerformLayout();
            arrayListHashtablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)idQueue).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceStack).EndInit();
            ((System.ComponentModel.ISupportInitialize)idStack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage listPage;
        private TabPage dictPage;
        private TabPage queuePage;
        private TabPage stackPage;
        private TabPage arrayListHashtablePage;
        private DateTimePicker listDateTimePicker;
        private TextBox nameListTextBox;
        private NumericUpDown priceListNumeric;
        private NumericUpDown idListNumeric;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button addListBtn;
        private Button delListBtn;
        private Button findListBtn;
        private DataGridView listDataGridView;
        private DateTimePicker dictDateTimePicker;
        private TextBox nameDictTextBox;
        private NumericUpDown priceDictNumeric;
        private NumericUpDown idDictNumeric;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button addDictBtn;
        private Button delDictBtn;
        private Button findDictBtn;
        private DataGridView dictDataGridView;
        private Button enqueueBtn;
        private Button dequeueBtn;
        private Button peekQueueBtn;
        private ListBox queueListBox;
        private ListBox stackListBox;
        private Button pushBtn;
        private Button popBtn;
        private Button peekStackBtn;
        private ListBox arrayListHashtableListBox;
        private Button hashtableBtn;
        private Button arrayListBtn;
        private DateTimePicker dateQueue;
        private TextBox nameQueue;
        private NumericUpDown priceQueue;
        private NumericUpDown idQueue;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dateStack;
        private TextBox nameStack;
        private NumericUpDown priceStack;
        private NumericUpDown idStack;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}