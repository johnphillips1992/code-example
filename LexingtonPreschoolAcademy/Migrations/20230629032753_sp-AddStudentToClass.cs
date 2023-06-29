using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spAddStudentToClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[AddStudentToClass]
                            @StudentId int,
                            @ClassId int
                        AS
                        BEGIN
	                        INSERT INTO StudentClasses (StudentId, ClassId)
                            VALUES (@StudentId, @ClassId)
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[AddStudentToClass];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
