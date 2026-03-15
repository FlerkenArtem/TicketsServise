using Npgsql;
using System.Data;

namespace TicketsServise
{
    public interface IDatabase
    {
        DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null);
        object ExecuteScalar(string query, NpgsqlParameter[] parameters = null);
        int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null);
    }
}
