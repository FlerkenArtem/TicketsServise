using Npgsql;

namespace TicketsServise
{
    public class TypeFilter : IFilter
    {
        private readonly string _type;
        public TypeFilter(string type)
        {
            _type = type;
        }
        public string GetCondition()
        {
            return "type = @type";
        }
        public NpgsqlParameter[] GetParameters()
        {
            return new[] { new NpgsqlParameter("@type", _type) };
        }
    }
}
