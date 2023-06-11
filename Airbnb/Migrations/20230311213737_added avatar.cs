using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class addedavatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords");

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Landlords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Avatar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Avatar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Avatar");

            migrationBuilder.AlterColumn<int>(
                name: "AvatarId",
                table: "Landlords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Avatar_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Avatar",
                principalColumn: "Id");
        }
    }
}
