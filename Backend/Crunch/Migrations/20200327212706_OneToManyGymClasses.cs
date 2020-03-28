using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class OneToManyGymClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gymID",
                table: "classes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_classes_gymID",
                table: "classes",
                column: "gymID");

            migrationBuilder.AddForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes");

            migrationBuilder.DropIndex(
                name: "IX_classes_gymID",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "gymID",
                table: "classes");
        }
    }
}
