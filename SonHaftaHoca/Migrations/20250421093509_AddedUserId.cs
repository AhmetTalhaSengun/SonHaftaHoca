using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SonHaftaHoca.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Aciklamas",
                table: "Eylemler",
                newName: "Aciklama");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Eylemler",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Eylemler_UserId",
                table: "Eylemler",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eylemler_AspNetUsers_UserId",
                table: "Eylemler",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eylemler_AspNetUsers_UserId",
                table: "Eylemler");

            migrationBuilder.DropIndex(
                name: "IX_Eylemler_UserId",
                table: "Eylemler");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Eylemler");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "Eylemler",
                newName: "Aciklamas");
        }
    }
}
