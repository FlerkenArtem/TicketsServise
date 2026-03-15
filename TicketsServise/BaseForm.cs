using Npgsql;
using System.Data;

namespace TicketsServise
{
    public abstract class BaseForm : Form
    {
        protected readonly IDatabase _db;

        protected BaseForm(IDatabase db)
        {
            _db = db;
        }

        protected void LoadDictionary<TKey>(ComboBox comboBox, string query,
                                            Func<DataRow, TKey> keySelector,
                                            Func<DataRow, string> valueSelector,
                                            params NpgsqlParameter[] parameters)
        {
            var dataTable = _db.ExecuteQuery(query, parameters);
            var dict = new Dictionary<TKey, string>();
            foreach (DataRow row in dataTable.Rows)
            {
                dict[keySelector(row)] = valueSelector(row);
            }
            comboBox.DataSource = dict.ToList();
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.SelectedIndex = -1;
        }
        protected DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters)
            => _db.ExecuteQuery(query, parameters);

        protected object ExecuteScalar(string query, params NpgsqlParameter[] parameters)
            => _db.ExecuteScalar(query, parameters);

        protected int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
            => _db.ExecuteNonQuery(query, parameters);
    }
}