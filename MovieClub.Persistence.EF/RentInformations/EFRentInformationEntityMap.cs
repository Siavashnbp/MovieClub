using Microsoft.EntityFrameworkCore;
using MovieClub.Entities.RentInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Persistence.EF.RentInformations
{
    public class EFRentInformationEntityMap : IEntityTypeConfiguration<RentInformation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RentInformation> builder)
        {
            builder.Property(_ => _.RentDuration).IsRequired().HasDefaultValue(TimeSpan.FromDays(7));
            builder.Property(_ => _.PricePerDay).IsRequired();
            builder.Property(_=>_.PenaltyPerDay).IsRequired();
        }
    }
}
