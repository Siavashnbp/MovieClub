using MovieClub.Services.Genres.Contracts.Dto;

namespace MovieClub.Test.Tools.Infrastructure.Genres.Factories
{
    public static class UpdateGenreDtoFactory
    {
        public static UpdateGenreDto Create()
        {
            return new UpdateGenreDto
            {
                Name = "updated_dummy_name"
            };
        }
    }
}