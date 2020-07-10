using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class TrainerUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gymID",
                table: "trainers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainers_gymID",
                table: "trainers",
                column: "gymID");

            migrationBuilder.AddForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers");

            migrationBuilder.DropIndex(
                name: "IX_trainers_gymID",
                table: "trainers");

            migrationBuilder.DropColumn(
                name: "gymID",
                table: "trainers");
        }
    }
}
