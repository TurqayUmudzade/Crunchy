using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class ClassAddedWithTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    duration = table.Column<string>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    gymLocation = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    space = table.Column<int>(nullable: false),
                    spaceUsed = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    icon = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "trainers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(nullable: false),
                    Speciality = table.Column<string>(nullable: false),
                    image = table.Column<string>(nullable: false),
                    aboutMe = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "trainers");
        }
    }
}
