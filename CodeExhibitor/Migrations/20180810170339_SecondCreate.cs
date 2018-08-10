using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExhibitor.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BigONotation",
                table: "Algorithms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigONotation",
                table: "Algorithms");
        }
    }
}
