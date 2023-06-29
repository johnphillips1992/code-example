using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexingtonPreschoolAcademy.Migrations
{
    public partial class spCreateStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[CreateStudent]
                            @FirstName varchar(50),
                            @LastName varchar(50),
                            @id int output
                        AS
                        BEGIN
	                        INSERT INTO Students (FirstName, LastName)
                            VALUES (@FirstName, @LastName)
                            SET @id=SCOPE_IDENTITY()
                            RETURN @id
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[CreateStudent];
                        GO";
            migrationBuilder.Sql(sp);
        }
    }
}
