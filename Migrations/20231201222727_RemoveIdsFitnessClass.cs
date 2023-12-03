using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPro.Migrations
{
    public partial class RemoveIdsFitnessClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "FitnessClasses");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "FitnessClasses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "FitnessClasses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "FitnessClasses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
