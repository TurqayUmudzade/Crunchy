using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    pin = table.Column<string>(nullable: true),
                    recieveSMS = table.Column<bool>(nullable: false),
                    recieveEmail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
