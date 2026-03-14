using Npgsql;

namespace TicketsServise
{
    public class CompositeFilter : IFilter
    {
        private readonly List<IFilter> _filters = new List<IFilter>();
        public void Add(IFilter filter)
        {
            _filters.Add(filter);
        }
        public string GetCondition()
        {
            if (_filters.Count == 0) return "1=1";
            return string.Join(" AND ", _filters.Select(f => f.GetCondition()));
        }
        public NpgsqlParameter[] GetParameters()
        {
            return _filters.SelectMany(f => f.GetParameters()).ToArray();
        }
    }
}
