using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTasteApp.DataAccess.Migrations
{
    public partial class Added_MenuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_FoodType_CategoryId",
                table: "MenuItem");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_FoodTypeId",
                table: "MenuItem",
                column: "FoodTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_FoodType_FoodTypeId",
                table: "MenuItem",
                column: "FoodTypeId",
                principalTable: "FoodType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_FoodType_FoodTypeId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_FoodTypeId",
                table: "MenuItem");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_FoodType_CategoryId",
                table: "MenuItem",
                column: "CategoryId",
                principalTable: "FoodType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
