using MovieClub.Entities.Movies;
using MovieClub.Entities.Ratings;

namespace MovieClub.Entities.Genres
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
