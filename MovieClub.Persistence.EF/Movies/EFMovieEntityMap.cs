using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieClub.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Persistence.EF.Movies
{
    public class EFMovieEntityMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).UseIdentityColumn();
            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Description).IsRequired();
            builder.Property(_ => _.Director).IsRequired();
            builder.Property(_ => _.AgeRestriction).IsRequired()
                .HasDefaultValue(AgeRestriction.None);
            builder.Property(_ => _.Count).IsRequired()
                .HasDefaultValue(1);
            builder.Property(_ => _.GenreId).IsRequired(false);
            builder.HasOne(_ => _.Genre).WithMany(_ => _.Movies)
                .HasForeignKey(_ => _.GenreId);
        }
    }
}
