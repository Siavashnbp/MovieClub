using Microsoft.EntityFrameworkCore;
using MovieClub.Entities.Genres;
using MovieClub.Entities.Movies;
using MovieClub.Entities.RentInformations;

namespace MovieClub.Persistence.EF;

public class EFDataContext : DbContext
{
    public EFDataContext(string connectionString) :
        this(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
    {
    }


    public EFDataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<RentInformation> RentInformations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly
            (typeof(EFDataContext).Assembly);
    }
}