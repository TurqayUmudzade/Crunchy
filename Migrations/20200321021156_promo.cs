using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class promo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "promocodes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    promocode = table.Column<string>(nullable: true),
                    discountPercent = table.Column<int>(nullable: false),
                    OneTime = table.Column<bool>(nullable: false),
                    Expire = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promocodes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "promocodes");
        }
    }
}
