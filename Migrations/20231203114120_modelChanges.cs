using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPro.Migrations
{
    public partial class modelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FitnessClassId",
                table: "FitnessClasses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FitnessClassId",
                table: "FitnessClasses");
        }
    }
}
