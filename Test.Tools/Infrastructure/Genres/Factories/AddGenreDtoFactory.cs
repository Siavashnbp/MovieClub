using MovieClub.Services.Genres.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Test.Tools.Infrastructure.Genres.Factories
{
    public static class AddGenreDtoFactory
    {
        public static AddGenreDto Create()
        {
            return new AddGenreDto
            {
                Name = "dummy-genre-name"
            };
        }
    }
}
