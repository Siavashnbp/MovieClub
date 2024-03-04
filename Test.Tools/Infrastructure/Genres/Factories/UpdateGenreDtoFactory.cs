namespace MovieClub.Services.Unit.Tests.Genres
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