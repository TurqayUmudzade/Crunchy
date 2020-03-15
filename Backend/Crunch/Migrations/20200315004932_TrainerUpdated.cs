using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class TrainerUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Qualifications",
                table: "trainers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "trainers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "trainers");
        }
    }
}
