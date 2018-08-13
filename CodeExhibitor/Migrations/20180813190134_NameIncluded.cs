using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExhibitor.Migrations
{
    public partial class NameIncluded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InterviewQuestions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Algorithms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "InterviewQuestions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Algorithms");
        }
    }
}
