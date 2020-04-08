using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class UserUpdated5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "membershipActiveTill",
                table: "users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "membershipActiveTill",
                table: "users");
        }
    }
}
