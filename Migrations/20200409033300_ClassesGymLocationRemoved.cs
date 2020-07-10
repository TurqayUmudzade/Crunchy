using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class ClassesGymLocationRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gymLocation",
                table: "classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gymLocation",
                table: "classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
