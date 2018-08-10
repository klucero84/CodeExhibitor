using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExhibitor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Algorithms",
                columns: table => new
                {
                    AlgorithmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Objective = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Algorithms", x => x.AlgorithmId);
                });

            migrationBuilder.CreateTable(
                name: "InterviewQuestions",
                columns: table => new
                {
                    InterviewQuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    Objective = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewQuestions", x => x.InterviewQuestionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Algorithms");

            migrationBuilder.DropTable(
                name: "InterviewQuestions");
        }
    }
}
