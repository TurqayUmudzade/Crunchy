using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class ClassUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "classes");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "classes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "gymID",
                table: "classes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "classes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "classes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gymID",
                table: "classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "classes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_classes_gyms_gymID",
                table: "classes",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
