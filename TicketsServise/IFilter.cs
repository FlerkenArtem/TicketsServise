using Npgsql;

namespace TicketsServise
{
    public interface IFilter
    {
        string GetCondition();
        NpgsqlParameter[] GetParameters();
    }
}
