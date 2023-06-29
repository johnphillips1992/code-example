using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spGetStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStudent]
                            @Id int
                        AS
                        BEGIN
	                        SET NOCOUNT ON;
	                        SELECT s.Id, s.FirstName, s.LastName
	                        FROM Students s
                            WHERE s.Id = @Id
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[GetStudent];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
