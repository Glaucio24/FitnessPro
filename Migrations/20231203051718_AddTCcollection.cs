using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPro.Migrations
{
    public partial class AddTCcollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FitnessClasses_AspNetUsers_FitnessUserId",
                table: "FitnessClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_AspNetUsers_FitnessUserId",
                table: "Trainers");

            migrationBuilder.AddForeignKey(
                name: "FK_FitnessClasses_AspNetUsers_FitnessUserId",
                table: "FitnessClasses",
                column: "FitnessUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_AspNetUsers_FitnessUserId",
                table: "Trainers",
                column: "FitnessUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FitnessClasses_AspNetUsers_FitnessUserId",
                table: "FitnessClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_AspNetUsers_FitnessUserId",
                table: "Trainers");

            migrationBuilder.AddForeignKey(
                name: "FK_FitnessClasses_AspNetUsers_FitnessUserId",
                table: "FitnessClasses",
                column: "FitnessUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_AspNetUsers_FitnessUserId",
                table: "Trainers",
                column: "FitnessUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
