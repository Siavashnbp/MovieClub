namespace MovieClub.Services.Unit.Tests.Movies
{
    public static class AddMovieDtoFactory
    {
        public static AddMovieDto Create()
        {
            return new AddMovieDto
            {
                Name = "dummy-movie-name",
                Director = "dummy-movie-director",
                Description = "dummy-movie-description",
                Duration = new TimeSpan(1, 25, 24)
            };
        }
    }

}