using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketsServise.Interfaces
{
    public partial class InterfacesDemoForm : Form
    {
        private List<TicketCollection> _collections = new List<TicketCollection>();
        private BindingSource _collectionsSrc =new BindingSource();

        public InterfacesDemoForm()
        {
            InitializeComponent();
            _collectionsSrc.DataSource = _collections;
            listBoxCollections.DataSource = _collectionsSrc;
            listBoxCollections.DisplayMember = "ToString";
        }

        private void btnCreate_Click(object sender, EventArgs e) // создание коллекции
        {
            _collections.Clear();

            var coll1 = new TicketCollection { CustomerName = "Иванов", OrderDate = DateTime.Today };
            coll1.AddTicket(new Ticket(1, "Концерт", DateTime.Now.AddDays(10), 1500));
            coll1.AddTicket(new Ticket(2, "Концерт", DateTime.Now.AddDays(10), 1500));

            var coll2 = new TicketCollection { CustomerName = "Петров", OrderDate = DateTime.Today };
            coll2.AddTicket(new Ticket(3, "Матч", DateTime.Now.AddDays(20), 500));
            coll2.AddTicket(new Ticket(4, "Матч", DateTime.Now.AddDays(20), 500));
            coll2.AddTicket(new Ticket(5, "Матч", DateTime.Now.AddDays(20), 500));

            var coll3 = new TicketCollection { CustomerName = "Сидоров", OrderDate = DateTime.Today };
            coll3.AddTicket(new Ticket(6, "Спектакль", DateTime.Now.AddDays(30), 2500));
            coll3.AddTicket(new Ticket(7, "Спектакль", DateTime.Now.AddDays(30), 2500));

            _collections.Add(coll1);
            _collections.Add(coll2);
            _collections.Add(coll3);

            _collectionsSrc.ResetBindings(false);
            Log("Коллекции созданы");
        }
        private void btnSortComparable_Click(object sender, EventArgs e) // сортировка по стоимости (IComparable)
        {
            _collections.Sort();
            _collectionsSrc.ResetBindings(false);
            Log("Коллекции отсортированы по общей стоимости");
        }
        private void btnSortComparer_Click(object sender, EventArgs e) // сортировка по количеству билетов (IComparer)
        {
            _collections.Sort(new TicketCollectionComparer());
            _collectionsSrc.ResetBindings(false);
            Log("Коллекции отсортированы по количеству билетов");
        }
        private void btnForeach_Click(object sender, EventArgs e) // перебор Foreach (IEnumerable)
        {
            if (listBoxCollections.SelectedItem is TicketCollection selected)
            {
                Log($"Перебор билетов заказа {selected.CustomerName}: ");
                foreach (var ticket in selected)
                {
                    Log($"  {ticket}");
                }
            }
            else
            {
                Log("Выберите коллекцию");
            }
        }
        private void btnClone_Click(object sender, EventArgs e) // копирование (ICloneable)
        {
            if (listBoxCollections.SelectedItem is TicketCollection original)
            {
                var clone = (TicketCollection)original.Clone();
                clone.CustomerName += "(Копия)";
                _collections.Add(clone);
                _collectionsSrc.ResetBindings(false);
                Log("Создана копия коллекции");
            }
            else
            {
                Log("Выберите коллекцию для клонирования");
            }
        }
        private void btnDispose_Click(object sender, EventArgs e) // очистка памяти (IDisposable)
        {
            if (listBoxCollections.SelectedItem is TicketCollection selected)
            {
                selected.Dispose();
                Log($"Ресурсы коллекции {selected.CustomerName} освобождены");
            }
            else
            {
                Log("Выберите коллекцию");
            }
        }

        private void Log(string message) // Вывод сообщений в ListBox
        {
            listBoxLog.Items.Add($"{DateTime.Now:T}: {message}");
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
        }
    }
}
