using MovieClub.Persistence.EF;
using MovieClub.Test.Tools.Infrastructure.DatabaseConfig.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Services.Unit.Tests.Movies
{
    public class MovieServiceTests
    {
        private readonly EFDataContext _context;
        private readonly EFInMemoryDatabase _db;
        public MovieServiceTests()
        {
            _db = new EFInMemoryDatabase();
            _context = _db.CreateDataContext<EFDataContext>();
        }
        //[Fact]
        //public Task Add_adds_movie_properly()
        //{
        //    var readContext = _db.CreateDataContext<EFDataContext>();

        //    var dto = AddMovieDtoFactory.Create();

        //    var sut = MovieServiceFactory.Create();
        //}
    }
}
