using Microsoft.EntityFrameworkCore.Migrations;

namespace ChristiansPieShop.Migrations
{
    public partial class AddedMorePies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 7, "", 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Peach_pie_%281469524201%29.jpg/320px-Peach_pie_%281469524201%29.jpg", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Peach_pie_%281469524201%29.jpg/320px-Peach_pie_%281469524201%29.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Pie", null, 13.95m, "Filled with peaches!" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 8, "", 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Goats_Curd_Cheese_Cake_-_Giant_Steps_Winery_AUD11_-_photo_by_Julia.jpg/320px-Goats_Curd_Cheese_Cake_-_Giant_Steps_Winery_AUD11_-_photo_by_Julia.jpg", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Goats_Curd_Cheese_Cake_-_Giant_Steps_Winery_AUD11_-_photo_by_Julia.jpg/320px-Goats_Curd_Cheese_Cake_-_Giant_Steps_Winery_AUD11_-_photo_by_Julia.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Goat's Curd Cheese Cake", null, 12.95m, "Filled with goat cheese!" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 9, "", 2, "https://upload.wikimedia.org/wikipedia/commons/d/d6/New_york_cheesecake_with_strawberries.jpg", "https://upload.wikimedia.org/wikipedia/commons/d/d6/New_york_cheesecake_with_strawberries.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "New York Cheese Cake", null, 11.95m, "Filled with cheese!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);
        }
    }
}
