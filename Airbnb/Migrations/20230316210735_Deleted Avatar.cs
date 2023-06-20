using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class DeletedAvatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Images_LandlordId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Images");

            migrationBuilder.CreateIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Images_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Images_AvatarId",
                table: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords");

            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_LandlordId",
                table: "Images",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Avatar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
