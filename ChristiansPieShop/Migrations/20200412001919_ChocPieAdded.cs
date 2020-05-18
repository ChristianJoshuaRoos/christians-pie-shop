using Microsoft.EntityFrameworkCore.Migrations;

namespace ChristiansPieShop.Migrations
{
    public partial class ChocPieAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 6, "", 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Chocolate_cream_pie.jpg/320px-Chocolate_cream_pie.jpg", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Chocolate_cream_pie.jpg/320px-Chocolate_cream_pie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Chocolate Pie", null, 14.95m, "Filled with chocolate!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);
        }
    }
}
