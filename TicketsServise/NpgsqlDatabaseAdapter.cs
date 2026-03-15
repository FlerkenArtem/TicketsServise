using Npgsql;
using System.Data;

namespace TicketsServise
{
    public class NpgsqlDatabaseAdapter : IDatabase
    {
        public NpgsqlDatabaseAdapter(string connectionString = "Host=localhost;Database=tickets_servise;Username=postgres;Password=postgres")
        {
            _connectionString = connectionString;
        }
        private static string _connectionString = "Host=localhost;Database=tickets_servise;Username=postgres;Password=postgres";
        public static string ConnectionString => _connectionString;
        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            var dataTable = new DataTable();

            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка выполнения запроса: " + ex.Message);
            }
            return dataTable;
        }
        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка выполнения запроса: " + ex.Message);
                return null;
            }
        }
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка выполнения запроса: " + ex.Message);
                return -1;
            }
        }
    }
}
