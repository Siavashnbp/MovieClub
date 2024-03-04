using Microsoft.EntityFrameworkCore;
using MovieClub.Entities.Genres;
using MovieClub.Persistence.EF;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Services.Genres.Contracts.Dto;

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
            _db.Genres.Add(genre);
        }

        public void Delete(Genre genre)
        {
            _db.Remove(genre);
        }

        public async Task<Genre?> FindById(int id)
        {
            return await _db.Genres.FirstOrDefaultAsync(_ => _.Id == id);
        }

        public async Task<Genre?> FindByName(string name)
        {
            return await _db.Genres.FirstOrDefaultAsync(_ => _.Name.ToLower() == name.ToLower());
        }

        public async Task<List<GetGenreResponeDto>> GetAll()
        {
            return await _db.Genres.Select(_ => new GetGenreResponeDto
            {
                Id = _.Id,
                Name = _.Name
            }).ToListAsync();
        }
    }
}