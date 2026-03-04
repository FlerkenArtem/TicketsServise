using Npgsql;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace TicketsServise
{
    public partial class BuyTicket : Form
    {
        private Guid BuyerId = Guid.Empty;
        private List<Ticket> _tickets = new List<Ticket>();
        private Dictionary<Guid, string> _paymentTypes = new Dictionary<Guid, string>();
        private BindingSource _paymentTypesSrc = new BindingSource();
        private List<byte[]> _documents = new List<byte[]>();

        public BuyTicket(List<Ticket> tickets, Guid buyer)
        {
            BuyerId = buyer;
            _paymentTypesSrc.DataSource = _paymentTypes;
            paymentTypeComboBox.DataSource = _paymentTypesSrc;
            LoadPaymentTypes();
            InitializeComponent();
        }
        private void LoadDataForDoc()
        {
            
        }
        private byte[] GenDocument(Ticket t, Event e)
        {
            byte[] doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x =>
                    x.FontSize(14));

                    page.Header()
                    .Text($"Билет на мероприятие: {e.Name}")
                    .SemiBold()
                    .FontSize(24)
                    .AlignCenter();

                    page.Content()
                    .AlignLeft()
                    .Text($"Дата и время: {e.EventDateTime.ToString()}" +
                          $"\nПлощадка проведения: {e.Place}" +
                          $"\nМесто в зале: {t.place}" +
                          $"\nСтоимость: {t.price.ToString()} рублей");

                    page.Footer()
                    .AlignBottom()
                    .Text($"Организатор мероприятия: {e.Orzanizer}" +
                          "\nБилет создан с помощью программы \"Платформа для организации мероприятий и продажи билетов\".")
                    .Thin()
                    .FontSize(8);
                });
            }).GeneratePdf();
            return doc;
        }
        private void LoadPaymentTypes()
        {
            try
            {
                var query = "SELECT * FROM payment_types;";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                paymentTypeComboBox.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string type = row["type"].ToString();
                    Guid id = Guid.Parse(row["id"].ToString());
                    _paymentTypes.Add(id, type);
                    _paymentTypesSrc.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            foreach (Ticket ticket in _tickets)
            {
                try
                {
                    var query = "SELECT event_data_for_ticket (@ticket_id);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@ticket_id", ticket.id)
                    };
                    DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                    Guid eId = Guid.Empty;
                    string? name = null;
                    string? organizer = null;
                    DateTime? dateTime = null;
                    string? place = null;
                    if (Guid.TryParse(dt.Rows[0][0].ToString(), out Guid id))
                    {
                        eId = id;
                    }
                    name = dt.Rows[0][1].ToString();
                    organizer = dt.Rows[0][2].ToString();
                    dateTime = DateTime.Parse(dt.Rows[0][3].ToString());
                    place = dt.Rows[0][4].ToString();
                    if (eId == Guid.Empty ||
                        string.IsNullOrEmpty(name) ||
                        string.IsNullOrEmpty(organizer) ||
                        string.IsNullOrEmpty(place) ||
                        dateTime == null)
                    {
                        MessageBox.Show("Не вся информация загружена",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Event ev = new Event(eId, name, organizer, dateTime.Value, place);
                        byte[] doc = GenDocument(ticket, ev);
                        _documents.Add(doc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                if (cardGroupBox.Enabled)
                {
                    var query = @"CALL buying (@tickets, 
                                @buyer, @files, @payment_type, 
                                @card_number, @valid_thru, @cvv2);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter
                        {
                            ParameterName = "@tickets",
                            NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Uuid,
                            Value = _tickets.Select(t => t.id).ToArray()
                        },
                        new NpgsqlParameter("@buyer", NpgsqlTypes.NpgsqlDbType.Uuid)
                        {
                            Value = BuyerId
                        },

                        new NpgsqlParameter
                        {
                            ParameterName = "@files",
                            NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Bytea,
                            Value = _documents.ToArray()
                        },

                        new NpgsqlParameter("@payment_type", NpgsqlTypes.NpgsqlDbType.Uuid)
                        {
                            Value = (Guid)paymentTypeComboBox.SelectedValue
                        },

                        new NpgsqlParameter("@card_number", NpgsqlTypes.NpgsqlDbType.Char)
                        {
                            Value = string.IsNullOrWhiteSpace(cardNumberTextBox.Text)
                                    ? DBNull.Value
                                    : cardNumberTextBox.Text
                        },

                        new NpgsqlParameter("@valid_thru", NpgsqlTypes.NpgsqlDbType.Char)
                        {
                            Value = string.IsNullOrWhiteSpace(validThruTextBox.Text)
                                    ? DBNull.Value
                                    : validThruTextBox.Text
                        },

                        new NpgsqlParameter("@cvv2", NpgsqlTypes.NpgsqlDbType.Char)
                        {
                            Value = string.IsNullOrWhiteSpace(cvv2TextBox.Text)
                                    ? DBNull.Value
                                    : cvv2TextBox.Text
                        }
                    };
                    var res = DatabaseHelper.ExecuteScalar(query, parameters);
                }
                else
                {
                    var query = @"CALL buying (@tickets, 
                                @buyer, @files, @payment_type);";
                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter
                        {
                            ParameterName = "@tickets",
                            NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Uuid,
                            Value = _tickets.Select(t => t.id).ToArray()
                        },
                        new NpgsqlParameter("@buyer", NpgsqlTypes.NpgsqlDbType.Uuid)
                        {
                            Value = BuyerId
                        },

                        new NpgsqlParameter
                        {
                            ParameterName = "@files",
                            NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Bytea,
                            Value = _documents.ToArray()
                        },

                        new NpgsqlParameter("@payment_type", NpgsqlTypes.NpgsqlDbType.Uuid)
                        {
                            Value = (Guid)paymentTypeComboBox.SelectedValue
                        }
                    };
                    var res = DatabaseHelper.ExecuteScalar(query, parameters);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void paymentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid cardGuid = Guid.Parse("019c2ec6-9c46-7f96-b45b-90575b8f41cc"); // ID карты в БД
            Guid currentGuid = (Guid)paymentTypeComboBox.SelectedValue;
            if (cardGuid == currentGuid)
            {
                cardGroupBox.Enabled = true;
                cardGroupBox.Visible = true;
            }
            else
            {
                return;
            }
        }
    }
}
