namespace MovieClub.Services.Unit.Tests.Movies
{
    public class AddMovieDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public TimeSpan Duration { get; set; }
    }
}