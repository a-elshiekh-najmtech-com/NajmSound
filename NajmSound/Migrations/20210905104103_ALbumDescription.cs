using Microsoft.EntityFrameworkCore.Migrations;

namespace NajmSound.Migrations
{
    public partial class ALbumDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Albums");
        }
    }
}
