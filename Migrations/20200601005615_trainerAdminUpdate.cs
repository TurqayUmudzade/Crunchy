using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class trainerAdminUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers");

            migrationBuilder.AlterColumn<int>(
                name: "gymID",
                table: "trainers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "trainers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers");

            migrationBuilder.AlterColumn<int>(
                name: "gymID",
                table: "trainers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "trainers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_trainers_gyms_gymID",
                table: "trainers",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
