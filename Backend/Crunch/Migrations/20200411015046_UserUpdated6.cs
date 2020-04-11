using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class UserUpdated6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gymLocation",
                table: "users");

            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "active",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "gymLocation",
                table: "users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
