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
        public void Add(AddGenreDto dto)
        {
            _genreServices.Add(dto);
        }
    }
}
