using FluentAssertions;
using MovieClub.Entities.Genres;
using MovieClub.Persistence.EF;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Test.Tools.Infrastructure.DatabaseConfig.Unit;
using MovieClub.Test.Tools.Infrastructure.Genres.Builders;
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
        [Fact]
        public async Task Add_throws_GenreExistsException_on_duplicate_names()
        {
            var dto = AddGenreDtoFactory.Create();
            var sut = GenreServiceFactory.Create(_context);

            var genre = new GenreBuilder().GenreWithName(dto.Name).Build();

            _context.Save(genre);

            var actual = async () => await sut.Add(dto);

            await actual.Should().ThrowExactlyAsync<GenreExistsException>();
        }
    }
}