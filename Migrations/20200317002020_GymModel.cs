using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class GymModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gyms",
                columns: table => new
                {
                    gymID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gymLocation = table.Column<string>(nullable: true),
                    gymAdress = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gyms", x => x.gymID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gyms");
        }
    }
}
