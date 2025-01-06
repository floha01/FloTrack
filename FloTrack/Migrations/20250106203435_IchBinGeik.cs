using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FloTrack.Migrations
{
    /// <inheritdoc />
    public partial class IchBinGeik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "FoodItems",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodItems",
                newName: "FoodName");
        }
    }
}
