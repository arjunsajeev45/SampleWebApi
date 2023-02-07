using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleWebApi.Migrations
{
    /// <inheritdoc />
    public partial class foregnkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_DId",
                table: "Employees",
                column: "DId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DId",
                table: "Employees",
                column: "DId",
                principalTable: "Departments",
                principalColumn: "DId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DId",
                table: "Employees");
        }
    }
}
