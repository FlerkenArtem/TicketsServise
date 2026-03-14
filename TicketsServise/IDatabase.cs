using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TicketsServise
{
    public interface IDatabase
    {
        DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null);
        object ExecuteScalar(string query, NpgsqlParameter[] parameters = null);
        int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null);
    }
}
