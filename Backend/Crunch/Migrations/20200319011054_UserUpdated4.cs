using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class UserUpdated4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "users",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Disscount",
                table: "users",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gymID",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "paymentOption",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_users_gymID",
                table: "users",
                column: "gymID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_gyms_gymID",
                table: "users",
                column: "gymID",
                principalTable: "gyms",
                principalColumn: "gymID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_gyms_gymID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_gymID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Disscount",
                table: "users");

            migrationBuilder.DropColumn(
                name: "gymID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "paymentOption",
                table: "users");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
