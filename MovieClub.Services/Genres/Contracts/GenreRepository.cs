using MovieClub.Entities.Genres;
using MovieClub.Services.Genres.Contracts.Dto;

namespace MovieClub.Services.Genres.Contracts
{
    public interface GenreRepository
    {
        void Add(Genre genre);
        void Delete(Genre genre);
        Task<Genre?> FindById(int id);
        Task<Genre?> FindByName(string name);
        Task<List<GetGenreResponeDto>> GetAll();
    }
}