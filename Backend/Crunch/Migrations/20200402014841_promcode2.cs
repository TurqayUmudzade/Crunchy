using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class promcode2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disscount",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "promocodeID",
                table: "users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "promocode",
                table: "promocodes",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "promocodes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_users_promocodeID",
                table: "users",
                column: "promocodeID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_promocodes_promocodeID",
                table: "users",
                column: "promocodeID",
                principalTable: "promocodes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_promocodes_promocodeID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_promocodeID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "promocodeID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "promocodes");

            migrationBuilder.AddColumn<string>(
                name: "Disscount",
                table: "users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "promocode",
                table: "promocodes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
