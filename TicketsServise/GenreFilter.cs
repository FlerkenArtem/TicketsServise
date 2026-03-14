using Npgsql;

namespace TicketsServise
{
    public class GenreFilter : IFilter
    {
        private readonly string _genre;
        public GenreFilter(string genre)
        {
            _genre = genre;
        }
        public string GetCondition()
        {
            return "genre = @genre";
        }
        public NpgsqlParameter[] GetParameters()
        {
            return new[] { new NpgsqlParameter("@genre", _genre) };
        }
    }
}
