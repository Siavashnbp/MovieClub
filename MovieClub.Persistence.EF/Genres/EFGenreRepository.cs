using MovieClub.Entities.Genres;
using MovieClub.Persistence.EF;
using MovieClub.Services.Genres.Contracts;

namespace MovieClub.Persistence.EF.Genres
{
    public class EFGenreRepository : GenreRepository
    {
        private readonly EFDataContext _db;
        public EFGenreRepository(EFDataContext db)
        {
            _db = db;
        }

        public void Add(Genre genre)
        {
            _db.Add(genre);
        }
    }
}