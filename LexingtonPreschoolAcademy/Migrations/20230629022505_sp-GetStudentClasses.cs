using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spGetStudentClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStudentClasses]
                            @StudentId int
                        AS
                        BEGIN
	                        SET NOCOUNT ON;
	                        SELECT sc.StudentId, sc.ClassId
	                        FROM StudentClasses sc
                            WHERE sc.StudentId = @StudentId
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[GetStudentClasses];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
