using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Migrations.Migrations
{
    [Migration(202403041507)]
    public class _202403041507_AddMovies : Migration
    {
        public override void Up()
        {
            Create.Table("Movies")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().NotNullable()
                .WithColumn("Director").AsString().NotNullable()
                .WithColumn("AgeRestriction").AsInt16().NotNullable()
                .WithColumn("GenreId").AsInt32().Nullable();
            Create.ForeignKey()
                .FromTable("Movies").ForeignColumn("GenreId")
                .ToTable("Genres").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("Movies");
        }

    }
}
