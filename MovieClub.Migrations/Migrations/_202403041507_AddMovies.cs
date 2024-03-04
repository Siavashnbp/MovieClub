using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Migrations.Migrations
{
    [Migration(202403041545)]
    public class _202403041545_AddRentInformation : Migration
    {
        public override void Up()
        {
            Create.Table("RentInformations")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("PricePerDay").AsDecimal().NotNullable()
                .WithColumn("PenaltyPerDay").AsDecimal().NotNullable()
                .WithColumn("RentDuration").AsDateTimeOffset().NotNullable();
            Create.ForeignKey()
                .FromTable("RentInformations").ForeignColumn("Id")
                .ToTable("Movies").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("RentInformations");
        }

    }
}
