using Npgsql;

namespace TicketsServise
{
    public class CityFilter : IFilter
    {
        private readonly string _city;
        public CityFilter(string city)
        {
            _city = city;
        }
        public string GetCondition()
        {
            return "city = @city";
        }
        public NpgsqlParameter[] GetParameters()
        {
            return new[] { new NpgsqlParameter("@city", _city) };
        }
    }
}
