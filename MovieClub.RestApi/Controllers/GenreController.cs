using Microsoft.AspNetCore.Mvc;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Services.Genres.Contracts.Dto;

namespace MovieClub.RestApi.Controllers
{
    [ApiController]
    [Route("api/Genre")]
    public class GenreController : ControllerBase
    {
        private readonly GenreServices _genreServices;
        public GenreController(GenreServices genreServices)
        {
            _genreServices = genreServices;
        }
        [HttpPost]
        public async Task Add([FromBody] AddGenreDto dto)
        {
            await _genreServices.Add(dto);
        }
        [HttpGet]
        public async Task<List<GetGenreResponeDto>> GetAll()
        {
            return await _genreServices.GetAll();
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _genreServices.Delete(id);
        }
        [HttpPut("/{id}")]
        public async Task Update([FromRoute] int id, [FromBody] UpdateGenreDto dto)
        {
            await _genreServices.Update(id, dto);
        }
    }

}
