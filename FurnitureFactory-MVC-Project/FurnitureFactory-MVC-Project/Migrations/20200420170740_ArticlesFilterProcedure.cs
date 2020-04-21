using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureFactory_MVC_Project.Migrations
{
    public partial class ArticlesFilterProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE GetProducts(@Contains VARCHAR(50))
                                   AS
                                   SELECT * FROM Articles
                                   WHERE Name LIKE '%'+ @Contains + '%'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE GetProducts");
        }
    }
}
