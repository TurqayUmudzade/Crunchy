using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class userUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gymLocation",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "premiumMemberShip",
                table: "users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gymLocation",
                table: "users");

            migrationBuilder.DropColumn(
                name: "premiumMemberShip",
                table: "users");
        }
    }
}
