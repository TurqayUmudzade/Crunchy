using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class adminRememmbermeRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rememberMe",
                table: "Admins");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "rememberMe",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
