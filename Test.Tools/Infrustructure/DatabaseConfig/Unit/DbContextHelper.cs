using Microsoft.EntityFrameworkCore;

namespace MovieClub.Test.Tools.Infrustructure.DatabaseConfig.Unit;

public static class DbContextHelper
{
    public static void Save<TDbContext, TEntity>(
        this TDbContext dbContext,
        TEntity entity)
        where TDbContext : DbContext
        where TEntity : class
    {
        dbContext.Add(entity);
        dbContext.SaveChanges();
    }
}