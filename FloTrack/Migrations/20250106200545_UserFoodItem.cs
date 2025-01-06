using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FloTrack.Migrations
{
    /// <inheritdoc />
    public partial class UserFoodItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFoodItem",
                columns: table => new
                {
                    FoodItemsId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodItem", x => new { x.FoodItemsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserFoodItem_FoodItems_FoodItemsId",
                        column: x => x.FoodItemsId,
                        principalTable: "FoodItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodItem_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodItem_UsersId",
                table: "UserFoodItem",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFoodItem");
        }
    }
}
