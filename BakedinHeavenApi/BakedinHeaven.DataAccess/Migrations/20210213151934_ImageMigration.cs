using Microsoft.EntityFrameworkCore.Migrations;

namespace BakedinHeaven.DataAccess.Migrations
{
    public partial class ImageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Items",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Items");
        }
    }
}
