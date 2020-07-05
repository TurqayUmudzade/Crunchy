using Microsoft.EntityFrameworkCore.Migrations;

namespace Crunch.Migrations
{
    public partial class FAQ1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "answer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "question",
                table: "FAQs");

            migrationBuilder.AddColumn<string>(
                name: "GroupAnswer",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupQuestion",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GymAnswer",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GymQuestion",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingAnswer",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainingQuestion",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "memberAccountAnswer",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "memberAccountQuestion",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "membershipAnswer",
                table: "FAQs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "membershipQuestion",
                table: "FAQs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupAnswer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "GroupQuestion",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "GymAnswer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "GymQuestion",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "TrainingAnswer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "TrainingQuestion",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "memberAccountAnswer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "memberAccountQuestion",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "membershipAnswer",
                table: "FAQs");

            migrationBuilder.DropColumn(
                name: "membershipQuestion",
                table: "FAQs");

            migrationBuilder.AddColumn<string>(
                name: "answer",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "question",
                table: "FAQs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
