using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spGetClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetClasses]
                        AS
                        BEGIN
	                        SET NOCOUNT ON;
	                        SELECT c.Id, c.Name
	                        FROM Classes c
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[GetClasses];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
