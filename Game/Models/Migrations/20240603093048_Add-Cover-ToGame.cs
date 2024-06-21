using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShop.Models.Migrations
{
    /// <inheritdoc />
    public partial class AddCoverToGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Games");
        }
    }
}
