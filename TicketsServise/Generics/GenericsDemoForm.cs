using System.Collections;
using System.Data;

namespace TicketsServise.Generics
{
    public partial class GenericsDemoForm : Form
    {
        // Создание обобщенных коллекций
        private List<Ticket> ticketList = new List<Ticket>();
        private Dictionary<int, Ticket> ticketDict = new Dictionary<int, Ticket>();
        private Queue<Ticket> ticketQueue = new Queue<Ticket>();
        private Stack<Ticket> ticketStack = new Stack<Ticket>();

        // Привязка данных
        private BindingSource listBindingSource = new BindingSource();
        private BindingSource dictBindingSource = new BindingSource();
        private BindingSource queueBindingSource = new BindingSource();
        private BindingSource stackBindingSource = new BindingSource();

        public GenericsDemoForm()
        {
            InitializeComponent();
            InitializeDataBindings();
            LoadSampleData();
        }
        private void InitializeDataBindings()
        {
            // List
            listBindingSource.DataSource = ticketList;
            listDataGridView.DataSource = listBindingSource;

            // Dictionary
            dictBindingSource.DataSource = ticketDict.Select(kvp => new { Key = kvp, Value = kvp.Value }).ToList();
            dictDataGridView.DataSource = dictBindingSource;

            // Queue
            queueBindingSource.DataSource = ticketQueue.ToList();
            queueListBox.DataSource = queueBindingSource;
            queueListBox.DisplayMember = "ToString";

            // Stack
            stackBindingSource.DataSource = ticketStack.ToList();
            stackListBox.DataSource = stackBindingSource;
            stackListBox.DisplayMember = "ToString";
        }
        private void LoadSampleData()
        {
            var t1 = new Ticket(1, "Концерт", 1500, DateTime.Now.AddDays(10));
            var t2 = new Ticket(2, "Спектакль", 3000, DateTime.Now.AddDays(20));
            var t3 = new Ticket(3, "Футбол", 500, DateTime.Now.AddDays(30));

            ticketList.AddRange(new[] { t1, t2, t3 });

            ticketDict.Add(1, t1);
            ticketDict.Add(2, t2);
            ticketDict.Add(3, t3);

            ticketQueue.Enqueue(t1);
            ticketQueue.Enqueue(t2);
            ticketQueue.Enqueue(t3);

            ticketStack.Push(t1);
            ticketStack.Push(t2);
            ticketStack.Push(t3);

            ResetAllBindings();
        }
        private void ResetAllBindings()
        {
            listBindingSource.ResetBindings(false);
            dictBindingSource.DataSource = ticketDict.Select(kvp => new { Key = kvp.Key, Value = kvp.Value }).ToList();
            dictBindingSource.ResetBindings(false);
            queueBindingSource.DataSource = ticketQueue.ToList();
            queueBindingSource.ResetBindings(false);
            stackBindingSource.DataSource = ticketStack.ToList();
            stackBindingSource.ResetBindings(false);
        }
        private void addListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idListNumeric.Value;
                string name = nameListTextBox.Text;
                decimal price = priceListNumeric.Value;
                DateTime date = listDateTimePicker.Value;

                var ticket = new Ticket(id, name, price, date);
                ticketList.Add(ticket);

                ResetAllBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void delListBtn_Click(object sender, EventArgs e)
        {
            if (listDataGridView.CurrentRow?.DataBoundItem is Ticket selected)
            {
                ticketList.Remove(selected);
                ResetAllBindings();
            }
            else
            {
                MessageBox.Show("Выберите билет для удаления.");
            }
        }
        private void findListBtn_Click(object sender, EventArgs e)
        {
            int id = (int)idListNumeric.Value;
            var found = ticketList.FirstOrDefault(x => x.Id == id);
            if (found != null)
            {
                MessageBox.Show($"Найден: {found}");
            }
            else
            {
                MessageBox.Show("Не найден");
            }
        }
        private void addDictBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idDictNumeric.Value;
                string name = nameDictTextBox.Text;
                decimal price = priceDictNumeric.Value;
                DateTime date = dictDateTimePicker.Value;

                if (ticketDict.ContainsKey(id))
                {
                    MessageBox.Show("Ключ уже существует");
                    return;
                }

                var ticket = new Ticket(id, name, price, date);
                ticketDict.Add(id, ticket);
                ResetAllBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void delDictBtn_Click(object sender, EventArgs e)
        {
            int id = (int)(idDictNumeric.Value);
            if (ticketDict.Remove(id))
            {
                ResetAllBindings();
            }
            else
            {
                MessageBox.Show("Ключ не найден");
            }
        }
        private void findDictBtn_Click(object sender, EventArgs e)
        {
            int id = (int)idDictNumeric.Value;
            if (ticketDict.TryGetValue(id, out Ticket ticket))
            {
                MessageBox.Show($"Найден {ticket}");
            }
            else
            {
                MessageBox.Show("Ключ не найден.");
            }
        }
        private void enqueueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idQueue.Value;
                string name = nameQueue.Text;
                decimal price = priceQueue.Value;
                DateTime date = dateQueue.Value;

                var ticket = new Ticket(id, name, price, date);
                ticketQueue.Enqueue(ticket);
                ResetAllBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dequeueBtn_Click(object sender, EventArgs e)
        {
            if (ticketQueue.Count > 0)
            {
                var removed = ticketQueue.Dequeue();
                MessageBox.Show($"Удален из очереди {removed}");
                ResetAllBindings();
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }
        }
        private void peekQueueBtn_Click(object sender, EventArgs e)
        {
            if (ticketQueue.Count > 0)
            {
                var first = ticketQueue.Peek();
                MessageBox.Show($"Первый в очереди: {first}");
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }
        }
        private void pushBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idStack.Value;
                string name = nameStack.Text;
                decimal price = priceStack.Value;
                DateTime date = dateStack.Value;

                var ticket = new Ticket(id, name, price, date);
                ticketStack.Push(ticket);
                ResetAllBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void popBtn_Click(object sender, EventArgs e)
        {
            if (ticketStack.Count > 0)
            {
                var removed = ticketStack.Pop();
                MessageBox.Show($"Удален из стека: {removed}");
                ResetAllBindings();
            }
            else
            {
                MessageBox.Show("Стек пуст.");
            }
        }
        private void peekStackBtn_Click(object sender, EventArgs e)
        {
            if (ticketStack.Count > 0)
            {
                var top = ticketStack.Peek();
                MessageBox.Show($"Верхний в стеке: {top}");
            }
            else
            {
                MessageBox.Show("Стек пуст.");
            }
        }
        private void arrayListBtn_Click(object sender, EventArgs e)
        {
            arrayListHashtableListBox.Items.Clear();
            try
            {
                ArrayList list = new ArrayList();
                list.Add(123);
                list.Add("строка");
                list.Add(new Ticket(1, "Хоккей", 100, DateTime.Now));

                arrayListHashtableListBox.Items.Add("Содержимое ArrayList (попытка приведения):");
                foreach (object item in list)
                {
                    Ticket t = (Ticket)item;
                    arrayListHashtableListBox.Items.Add(t.ToString());
                }
            }
            catch (Exception ex)
            {
                arrayListHashtableListBox.Items.Add($"Ошибка: {ex.Message}");
                arrayListHashtableListBox.Items.Add("Это демонстрирует проблему необобщенных коллекций: отсутствие типобезопасности.");
            }
        }

        private void hashtableBtn_Click(object sender, EventArgs e)
        {
            arrayListHashtableListBox.Items.Clear();
            try
            {
                Hashtable table = new Hashtable();
                table.Add(1, new Ticket(1, "Концерт", 1500, DateTime.Now));
                table.Add("два", "неверный тип");

                arrayListHashtableListBox.Items.Add("Содержимое Hashtable (попытка приведения):");
                foreach (DictionaryEntry entry in table)
                {
                    int key = (int)entry.Key;
                    Ticket value = (Ticket)entry.Value;
                    arrayListHashtableListBox.Items.Add($"{key}: {value}");
                }
            }
            catch (Exception ex)
            {
                arrayListHashtableListBox.Items.Add($"Ошибка: {ex.Message}");
                arrayListHashtableListBox.Items.Add("Это демонстрирует проблему необобщенных коллекций: отсутствие типобезопасности.");
            }
        }
    }
}
