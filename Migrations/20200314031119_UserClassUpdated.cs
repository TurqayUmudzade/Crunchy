using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class UserClassUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "classes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "ClassID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "classes");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "classes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "ID");
        }
    }
}
