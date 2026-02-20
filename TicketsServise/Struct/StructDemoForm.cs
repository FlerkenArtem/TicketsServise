using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketsServise.Struct
{
    public partial class StructDemoForm : Form
    {
        private List<Ticket> _structList = new List<Ticket>();
        private List<ClassTicket> _classList = new List<ClassTicket>();
        private BindingSource _structListSrc = new BindingSource();
        private BindingSource _classListSrc = new BindingSource();
        public StructDemoForm()
        {
            InitializeComponent();
            _structListSrc.DataSource = _structList;
            _classListSrc.DataSource = _classList;
            structListBox.DataSource = _structListSrc;
            classListBox.DataSource = _classListSrc;
            structListBox.DisplayMember = "ToString";
            classListBox.DisplayMember = "ToString";
        }
        public void addStructBtn_Click(object sender, EventArgs e)
        {
            var structTicket = new Ticket(1, "Концерт", 1500, DateTime.Now.AddDays(10));
            _structList.Add(structTicket);
            _structListSrc.ResetBindings(false);
        }
        public void copyStructBtn_Click(Object sender, EventArgs e)
        {
            if (structListBox.SelectedItem is Ticket original)
            {
                var copyStruct = original;
                copyStruct.EventName = original.EventName + " (Копия)";
                _structList.Add(copyStruct);
                _structListSrc.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Не выбрана структура для создания копии", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void editPriceStructBtn_Click(object obj, EventArgs e)
        {
            if (structListBox.SelectedItem is Ticket selected)
            {
                selected.Price = 500;
                _structListSrc.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Не выбрана структура для изменения цены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void addClassBtn_Click(object sender, EventArgs e)
        {
            var classTicket = new ClassTicket(1, "Концерт", 1500, DateTime.Now.AddDays(10));
            _classList.Add(classTicket);
            _classListSrc.ResetBindings(false);
        }
        public void copyClassBtn_Click(Object sender, EventArgs e)
        {
            if (classListBox.SelectedItem is ClassTicket original)
            {
                var copyClass = original;
                copyClass.EventName = original.EventName + " (Копия)";
                _classList.Add(copyClass);
                _classListSrc.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Не выбран класс для создания копии", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void editPriceClassBtn_Click(object obj, EventArgs e)
        {
            if (classListBox.SelectedItem is ClassTicket selected)
            {
                selected.Price = 500;
                _classListSrc.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Не выбран класс для изменения цены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
