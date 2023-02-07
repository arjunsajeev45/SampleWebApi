using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleWebApi.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeyadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DId",
                table: "Employees");
        }
    }
}
