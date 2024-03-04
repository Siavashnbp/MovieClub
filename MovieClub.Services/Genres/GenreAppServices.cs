using MovieClub.Contracts.Interfaces;
using MovieClub.Entities.Genres;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Services.Genres.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Services.Genres
{
    public class GenreAppServices : GenreServices
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GenreRepository _repository;
        public GenreAppServices(GenreRepository genreRepository, UnitOfWork unitOfWork)
        {
            _repository = genreRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(AddGenreDto dto)
        {
            var genre = new Genre
            {
                Name = dto.Name,
            };
            _repository.Add(genre);
            await _unitOfWork.Complete();
        }
    }
}
