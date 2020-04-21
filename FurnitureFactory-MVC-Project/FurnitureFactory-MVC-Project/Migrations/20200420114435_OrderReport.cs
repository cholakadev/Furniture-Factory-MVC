using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureFactory_MVC_Project.Migrations
{
    public partial class OrderReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW OrderReport AS
                                   SELECT [OrderNumber], [Date], [TotalPrice]
                                   FROM Sales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW OrderReport");
        }
    }
}
