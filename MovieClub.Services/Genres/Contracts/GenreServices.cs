using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieClub.Services.Genres.Contracts.Dto;

namespace MovieClub.Services.Genres.Contracts
{
    public interface GenreServices
    {
        Task Add(AddGenreDto dto);
        Task Delete(int id);
        Task<List<GetGenreResponeDto>> GetAll();
        Task Update(int id, UpdateGenreDto updateDto);
    }
}
