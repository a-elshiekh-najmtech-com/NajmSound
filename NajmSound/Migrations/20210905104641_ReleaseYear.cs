using Microsoft.EntityFrameworkCore.Migrations;

namespace NajmSound.Migrations
{
    public partial class ReleaseYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReleaseYear",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReleaseYear",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Albums");
        }
    }
}
