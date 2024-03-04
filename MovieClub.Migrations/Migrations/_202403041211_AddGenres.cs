using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Migrations.Migrations
{
    [Migration(202403041211)]
    public class _202403041211_AddGenres : Migration
    {

        public override void Up()
        {
            Create.Table("Genres")
                .WithColumn("Id").AsInt32().Identity().NotNullable()
                .WithColumn("Name").AsString().NotNullable();

        }
        public override void Down()
        {
            Delete.Table("Genres");
        }
    }
}
