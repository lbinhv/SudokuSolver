using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SudokuSolver.DataAccess.Migrations
{
    public partial class SudokuSolverDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolutionResults",
                columns: table => new
                {
                    SolutionResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SolutionStatus = table.Column<int>(type: "int", nullable: false),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionResults", x => x.SolutionResultId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolutionResults");
        }
    }
}
