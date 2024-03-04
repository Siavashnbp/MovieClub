using MovieClub.Persistence.EF;
using MovieClub.Persistence.EF.Genres;
using MovieClub.Services.Genres;
using MovieClub.Services.Genres.Contracts;

namespace MovieClub.Test.Tools.Infrastructure.Genres.Factories
{
    public static class GenreServiceFactory
    {
        public static GenreServices Create(EFDataContext context)
        {
            return new GenreAppServices(new EFGenreRepository(context), new EFUnitOfWork(context));
        }
    }
}
