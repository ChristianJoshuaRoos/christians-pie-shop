using Microsoft.EntityFrameworkCore.Migrations;

namespace ChristiansPieShop.Migrations
{
    public partial class NotesAddedOnPie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pies");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "wwwroot/images/apple_pie.jpg", "wwwroot/images/apple_pie.jpg" });
        }
    }
}
