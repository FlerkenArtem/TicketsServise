using Npgsql;

namespace TicketsServise
{
    public class PlaceFilter : IFilter
    {
        private readonly string _place;
        public PlaceFilter(string place)
        {
            _place = place;
        }
        public string GetCondition()
        {
            return "place = @place";
        }
        public NpgsqlParameter[] GetParameters()
        {
            return new[] { new NpgsqlParameter("@place", _place) };
        }
    }
}
