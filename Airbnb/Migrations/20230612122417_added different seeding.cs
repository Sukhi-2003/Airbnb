using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class addeddifferentseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "john.doe@example.com", "John", "Doe" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "jane.doe@example.com", "Jane", "Doe" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { 1, "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { false, 1, "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { 2, "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { false, 2, "https://writestylesonline.com/wp-content/uploads/2018/11/Three-Statistics-That-Will-Make-You-Rethink-Your-Professional-Profile-Picture.jpg" });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Peter-Jan", "Balkenende" });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Jan", "de Man" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FeaturesList", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[] { "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.", 28, 4, 75f, 2, "Lekker veel ruimte", "De Boerenhoeve", 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FeaturesList", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title" },
                values: new object[] { "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.", 52, 6, 100f, 3, "Te gek uitzicht", "Frankie's Penthouse" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "EndDate", "StartDate" },
                values: new object[] { 0.1f, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LocationId", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[] { 1, 0.2f, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[] { 4, 2, 0.15f, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "MrBean@gmail.com", "Mr", "Bean" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "NapoleonBonaparte@gmail.com", "Napoleon", "Bonaparte" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "AliG@gmail.com", "Ali", "G" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { null, "https://upload.wikimedia.org/wikipedia/commons/8/81/Peter_R._de_Vries_%28headshot%29.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { true, null, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5a/Plop_lutin_Plopsaland.jpg/640px-Plop_lutin_Plopsaland.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocationId", "Url" },
                values: new object[] { null, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Aston_Martin_DB5%2C_James_Bond_04.jpg/640px-Aston_Martin_DB5%2C_James_Bond_04.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsCover", "LocationId", "Url" },
                values: new object[] { true, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Taj_Mahal%2C_Agra%2C_India_edit3.jpg/640px-Taj_Mahal%2C_Agra%2C_India_edit3.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 5, false, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/El_Taj_Mahal-Agra_India0023.JPG/640px-El_Taj_Mahal-Agra_India0023.JPG" },
                    { 6, true, 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/Big_Ben_at_sunset_-_2014-10-27_17-30.jpg/640px-Big_Ben_at_sunset_-_2014-10-27_17-30.jpg" },
                    { 7, false, 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg/640px-London_Big_Ben_Inner_Clock_Face_1070925-PSD.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Peter R", "De Vries" });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 44, "Kabouter", "Plop" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 3, 66, 3, "James", "Bond" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FeaturesList", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[] { "The temple of Shah Jahan mad for his wife", 34, 12, 300f, 5, "A simps biggest effort", "Taj Mahal", 5 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FeaturesList", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title" },
                values: new object[] { "This is not a property of Ben", 34, 2, 500f, 2, "UK's biggest tourist attraction", "Big Ben" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "FeaturesList", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "Biggest building in Dubai", 34, 1, 5, 200f, 6, "Something influencers wet there pants for", "Burj Khalifa", 0 },
                    { 4, "The 8th wonder of the world", 34, 1, 3, 500f, 3, "Pointer than the edge of a katana", "Pyramid of Giza", 3 },
                    { 5, "Where the monks like to chill", 34, 2, 6, 340f, 7, "Located up in the mountains", "Shaolin Temple", 0 },
                    { 6, "The main attraction of the Constantinopel", 34, 1, 2, 380f, 2, "You wouldn't believe the beauty of this place", "Hagia Sophia", 3 },
                    { 8, "This house is not meant for dancing", 34, 1, 5, 670f, 5, "Where dancers sleep", "Dancing House", 5 },
                    { 9, "This name hurts to pronounce", 34, 2, 4, 160f, 4, "I have no idea", "Château de Chenonceau", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "EndDate", "StartDate" },
                values: new object[] { 0f, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "LocationId", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[] { 3, 0f, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 8, true, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Burj_Khalifa_Night_View_04.jpg/640px-Burj_Khalifa_Night_View_04.jpg" },
                    { 9, false, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Burj_Khalifa_%2816260269606%29.jpg/640px-Burj_Khalifa_%2816260269606%29.jpg" },
                    { 10, true, 4, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Kheops-Pyramid.jpg/640px-Kheops-Pyramid.jpg" },
                    { 11, false, 4, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Pyramid_of_Cheops_-_side.jpg/640px-Pyramid_of_Cheops_-_side.jpg" },
                    { 12, true, 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Shaolinsi.JPG/640px-Shaolinsi.JPG" },
                    { 13, false, 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Shaolin_Temple_%2810201460885%29.jpg/640px-Shaolin_Temple_%2810201460885%29.jpg" },
                    { 14, true, 6, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Hagia_Sophia_Mars_2013.jpg/640px-Hagia_Sophia_Mars_2013.jpg" },
                    { 15, false, 6, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Hagia_Sophia_-_Kuppelbau.jpg/640px-Hagia_Sophia_-_Kuppelbau.jpg" },
                    { 18, true, 8, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Dancing_house_prague.JPG/640px-Dancing_house_prague.JPG" },
                    { 19, false, 8, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Dancing_house_green_light.JPG/640px-Dancing_house_green_light.JPG" },
                    { 20, true, 9, "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Chenonceau-20050320.jpg/640px-Chenonceau-20050320.jpg" },
                    { 21, false, 9, "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg/640px-Ch%C3%A2teau_de_Chenonceau_-_Fa%C3%A7ade_Ouest_et_Tour_des_Marques_reflets.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "FeaturesList", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 7, "I think it's a pretty weird name", 34, 3, 2, 230f, 3, "No further introduction", "The Guggenheim", 0 },
                    { 10, "Where philosophers liked to hang around", 34, 3, 2, 300f, 2, "Where naked statues are", "Acropolis of Athens", 4 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 16, true, 7, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/The_Guggenheim_Museum_%281%29.jpg/640px-The_Guggenheim_Museum_%281%29.jpg" },
                    { 17, false, 7, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/New_York_Guggenheim-Museum_1995.jpg/640px-New_York_Guggenheim-Museum_1995.jpg" },
                    { 22, true, 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg/640px-Restoration_work_Parthenon_facade_Acropolis_Athens_Greece.jpg" },
                    { 23, false, 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Acropolis%2C_Athens_GRE.jpg/640px-Acropolis%2C_Athens_GRE.jpg" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_LocationId",
                table: "Reservations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
