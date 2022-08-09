using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodCourt.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food Categories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryName = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food Categories", x => x.FoodCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    FoodCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Food Categories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "Food Categories",
                        principalColumn: "FoodCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderedFoodName = table.Column<string>(maxLength: 100, nullable: false),
                    OrderedQuantity = table.Column<int>(nullable: false),
                    FoodCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Food Categories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "Food Categories",
                        principalColumn: "FoodCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FoodCategoryId",
                table: "Orders",
                column: "FoodCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Food Categories");
        }
    }
}
