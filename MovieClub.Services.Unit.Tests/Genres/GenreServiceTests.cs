using FluentAssertions;
using MovieClub.Persistence.EF;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Test.Tools.Infrastructure.DatabaseConfig.Unit;
using MovieClub.Test.Tools.Infrastructure.Genres.Factories;

namespace MovieClub.Services.Unit.Tests.Genres
{
    public class GenreServiceTests
    {
        private readonly EFInMemoryDatabase _db;
        private readonly EFDataContext _context;
        public GenreServiceTests()
        {
            _db = new EFInMemoryDatabase();
            _context = _db.CreateDataContext<EFDataContext>();
        }
        [Fact]
        public async Task Add_adds_genre_properly()
        {
            var readContext = _db.CreateDataContext<EFDataContext>();

            var dto = AddGenreDtoFactory.Create();
            var sut = GenreServiceFactory.Create(_context);

            await sut.Add(dto);

            var actual = readContext.Genres.Single();

            actual.Name.Should().Be(dto.Name);
        }
    }
}