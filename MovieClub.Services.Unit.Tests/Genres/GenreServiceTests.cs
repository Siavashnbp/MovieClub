using MovieClub.Persistence.EF;
using MovieClub.Test.Tools.Infrustructure.DatabaseConfig.Unit;

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
        public void Add_adds_genre_properly()
        {

        }
    }
}