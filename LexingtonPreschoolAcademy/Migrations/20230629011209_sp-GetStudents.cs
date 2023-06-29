using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spGetStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStudents]
                        AS
                        BEGIN
	                        SET NOCOUNT ON;
	                        SELECT s.Id, s.FirstName, s.LastName
	                        FROM Students s
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[GetStudents];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
