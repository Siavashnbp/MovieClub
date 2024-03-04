using MovieClub.Entities.Genres;

namespace MovieClub.Services.Genres.Contracts
{
    public interface GenreRepository
    {
        void Add(Genre genre);
    }
}