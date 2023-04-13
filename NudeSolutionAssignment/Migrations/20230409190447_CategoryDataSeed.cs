using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NudeSolutionAssignment.Migrations
{
    /// <inheritdoc />
    public partial class CategoryDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[] { "Electronics" });
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[] { "Clothings" });
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[] { "Kitchen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
