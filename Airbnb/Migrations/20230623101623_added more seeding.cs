using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class addedmoreseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "jane.doe@example.com", "Jane" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://www.adobe.com/nl/express/create/media_1bcd514348a568faed99e65f5249895e38b06c947.jpeg?width=400&format=jpeg&optimize=medium");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MaisonCausapscal.JPG/640px-MaisonCausapscal.JPG");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Ljungris_July_2013.jpg/640px-Ljungris_July_2013.jpg");

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Peter-Jan", "Balkenende" });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jan", "de Man" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FeaturesList", "PricePerDay", "Rooms", "SubTitle", "Title" },
                values: new object[] { "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.", 28, 75f, 2, "Lekker veel ruimte", "De Boerenhoeve" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FeaturesList", "PricePerDay", "Title", "Type" },
                values: new object[] { "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.", 52, 100f, "Frankie's Penthouse", 1 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "FeaturesList", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "Experience the ultimate beach vacation in this stunning seaside getaway. Enjoy breathtaking ocean views, luxurious amenities, and direct access to the beach.", 13, 1, 2, 90f, 1, "Relax by the beach", "Seaside Getaway", 0 },
                    { 6, "Experience the charm of country living in this beautiful rustic farmhouse. Surrounded by rolling hills and lush greenery, it's the perfect retreat for those seeking peace and tranquility.", 48, 1, 5, 80f, 2, "A taste of country living", "Rustic Farmhouse", 3 },
                    { 7, "Stay in the heart of the city in this cozy studio apartment. Enjoy easy access to restaurants, shops, and attractions, and experience the vibrant energy of the city.", 7, 2, 2, 60f, 1, "City center convenience", "Cozy Studio", 0 },
                    { 9, "Step into this stylish and modern loft and be captivated by its industrial chic design. With its open floor plan, high ceilings, and state-of-the-art amenities, it's the perfect urban retreat.", 28, 1, 4, 95f, 2, "Industrial chic", "Modern Loft", 4 },
                    { 10, "Indulge in the lap of luxury in this breathtaking villa. With its lavish interiors, private pool, and impeccable service, it offers an unforgettable experience of pure elegance and opulence.", 44, 2, 8, 250f, 3, "Exquisite elegance", "Luxury Villa", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 0.1f);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Discount", "StartDate" },
                values: new object[] { 0f, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "StartDate" },
                values: new object[] { 0.2f, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "LocationId" },
                values: new object[] { 0.15f, 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 7, false, 3, "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8cmFuZG9tJTIwcGVyc29ufGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 8, true, 3, "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 9, false, 3, "https://images.unsplash.com/photo-1502005097973-6a7082348e28?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60" },
                    { 14, true, 6, "https://images.unsplash.com/photo-1602343168117-bb8ffe3e2e9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 15, false, 6, "https://images.unsplash.com/photo-1501685532562-aa6846b14a0e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 16, true, 7, "https://images.unsplash.com/photo-1430285561322-7808604715df?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 17, false, 7, "https://images.unsplash.com/photo-1611145367596-364abefb1f9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 20, true, 9, "https://images.unsplash.com/photo-1588012886079-baef0ac45fbd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzB8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 21, false, 9, "https://images.unsplash.com/photo-1484301548518-d0e0a5db0fc8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mjl8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 22, true, 10, "https://images.unsplash.com/photo-1600607688969-a5bfcd646154?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzZ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 23, false, 10, "https://images.unsplash.com/photo-1599619351208-3e6c839d6828?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzR8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" }
                });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[] { 3, 25, 7, "Sandra", "Vries" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "FeaturesList", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 4, "Surrounded by majestic mountains, this cozy retreat offers a peaceful and idyllic setting. Explore hiking trails, enjoy outdoor activities, or simply relax in the comfort of your mountain getaway.", 22, 3, 4, 120f, 2, "Escape to nature", "Mountain Retreat", 1 },
                    { 5, "Indulge in the vibrant city life while enjoying the comfort of this stylish urban oasis. With its modern design, top-notch amenities, and convenient location, it's the perfect choice for your city adventure.", 44, 3, 3, 150f, 3, "Urban luxury", "City Oasis", 0 },
                    { 8, "Escape to this charming lakefront cottage and immerse yourself in the serenity of nature. Relax on the private dock, go fishing, or simply enjoy the breathtaking views of the tranquil lake.", 14, 3, 6, 110f, 3, "Unwind by the lake", "Lakefront Cottage", 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 10, true, 4, "https://images.unsplash.com/photo-1600047509807-ba8f99d2cdde?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 11, false, 4, "https://images.unsplash.com/photo-1591247378418-c77f1532d2f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60" },
                    { 12, true, 5, "https://images.unsplash.com/photo-1605146769289-440113cc3d00?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 13, false, 5, "https://images.unsplash.com/photo-1629079448105-35ab3e5152d4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 18, true, 8, "https://images.unsplash.com/photo-1600047509358-9dc75507daeb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjR8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 19, false, 8, "https://images.unsplash.com/photo-1607582544644-f1da2a004994?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mary.jane@example.com", "Mary", "Jane" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "john.doe@example.com", "John" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://writestylesonline.com/wp-content/uploads/2018/11/Three-Statistics-That-Will-Make-You-Rethink-Your-Professional-Profile-Picture.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Ranch_style_home_in_Salinas%2C_California.JPG/640px-Ranch_style_home_in_Salinas%2C_California.JPG");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Katsura_Imperial_Villa_in_Spring.jpg/640px-Katsura_Imperial_Villa_in_Spring.jpg");

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gustav", "Maher" });

            migrationBuilder.UpdateData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mahatma", "Ghandi" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "FeaturesList", "PricePerDay", "Rooms", "SubTitle", "Title" },
                values: new object[] { "een betoverend huis omringd door bloemen, rustig, comfortabel en vol natuurlijk licht.", 20, 200f, 1, "Waar de zon continu schijnt", "Het bloemensteeltje" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FeaturesList", "PricePerDay", "Title", "Type" },
                values: new object[] { "een charmant huis, levendig en kleurrijk, met een vrolijke sfeer, omgeven door speelse tuinen.", 36, 240f, "De Petteflet", 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 0.5f);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Discount", "StartDate" },
                values: new object[] { 0.1f, new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Discount", "StartDate" },
                values: new object[] { 0.6f, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "LocationId" },
                values: new object[] { 0.5f, 2 });
        }
    }
}
