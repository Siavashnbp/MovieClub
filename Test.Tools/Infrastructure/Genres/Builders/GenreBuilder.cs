using MovieClub.Entities.Genres;

namespace MovieClub.Test.Tools.Infrastructure.Genres.Builders
{
    public class GenreBuilder
    {
        private readonly Genre _genre;
        public GenreBuilder()
        {
            _genre = new Genre { Name = "genre-dummy-name" };
        }
        public GenreBuilder GenreWithName(string name)
        {
            _genre.Name = name;
            return this;
        }
        public Genre Build() => _genre;
    }
}
