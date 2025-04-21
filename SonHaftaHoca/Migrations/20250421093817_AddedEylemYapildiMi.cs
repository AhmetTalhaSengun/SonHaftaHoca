using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SonHaftaHoca.Migrations
{
    /// <inheritdoc />
    public partial class AddedEylemYapildiMi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EylemYapildiMi",
                table: "Eylemler",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EylemYapildiMi",
                table: "Eylemler");
        }
    }
}
