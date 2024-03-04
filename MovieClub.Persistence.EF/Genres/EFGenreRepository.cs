using Microsoft.EntityFrameworkCore;
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

        public async Task<Genre?> FindGenreByName(string name)
        {
            return await _db.Set<Genre>().FirstOrDefaultAsync(_=>_.Name.ToLower() == name.ToLower());
        }
    }
}