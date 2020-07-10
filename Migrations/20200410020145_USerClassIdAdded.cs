using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class USerClassIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserClassID",
                table: "UserClass",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserClassID",
                table: "UserClass");
        }
    }
}
