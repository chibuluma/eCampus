using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCampus.DAL.Migrations
{
    public partial class added_reference_key_from_school_departments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_SchoolId",
                table: "Departments",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_School_SchoolId",
                table: "Departments",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_School_SchoolId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_SchoolId",
                table: "Departments");
        }
    }
}
