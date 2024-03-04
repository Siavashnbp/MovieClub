using FluentAssertions;
using MovieClub.Entities.Genres;
using MovieClub.Persistence.EF;
using MovieClub.Services.Genres.Contracts;
using MovieClub.Services.Genres.Exceptions;
using MovieClub.Test.Tools.Infrastructure.DatabaseConfig.Unit;
using MovieClub.Test.Tools.Infrastructure.Genres.Builders;
using MovieClub.Test.Tools.Infrastructure.Genres.Factories;
using SQLitePCL;

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
        [Fact]
        public async Task GetAll_gets_all_genres_properly()
        {
            var readContext = _db.CreateDataContext<EFDataContext>();

            var genre1 = new GenreBuilder().GenreWithName("dummy-genre1-name").Build();
            _context.Save(genre1);
            var genre2 = new GenreBuilder().GenreWithName("dummy-genre2-name").Build();
            _context.Save(genre2);

            var sut = GenreServiceFactory.Create(_context);

            var actual = await sut.GetAll();

            actual[0].Id.Should().Be(genre1.Id);
            actual[0].Name.Should().Be(genre1.Name);

            actual[1].Id.Should().Be(genre2.Id);
            actual[1].Name.Should().Be(genre2.Name);
        }

        [Fact]
        public async Task Delete_deletes_genre_properly()
        {
            var readContext = _db.CreateDataContext<EFDataContext>();

            var genre = new GenreBuilder().Build();
            _context.Save(genre);

            var sut = GenreServiceFactory.Create(_context);
            await sut.Delete(genre.Id);

            var actual = readContext.Genres.Any();

            actual.Should().BeFalse();
        }

        [Fact]
        public async Task Delete_throws_GenreNotFoundException()
        {
            var dummyId = 0;
            var sut = GenreServiceFactory.Create(_context);

            var actual = async () => await sut.Delete(dummyId);

            await actual.Should().ThrowExactlyAsync<GenreNotFoundException>();
        }
        [Fact]
        public async Task Update_updates_genre_properly()
        {
            var readContext = _db.CreateDataContext<EFDataContext>();

            var genre = new GenreBuilder().Build();
            _context.Save(genre);

            var updateDto = UpdateGenreDtoFactory.Create();
            var sut = GenreServiceFactory.Create(_context);

            await sut.Update(genre.Id, updateDto);

            var actual = readContext.Genres.Single();

            actual.Id.Should().Be(genre.Id);
            actual.Name.Should().Be(updateDto.Name);
        }
    }
}