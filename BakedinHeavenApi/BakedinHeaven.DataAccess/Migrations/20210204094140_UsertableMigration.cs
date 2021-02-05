using Microsoft.EntityFrameworkCore.Migrations;

namespace BakedinHeaven.DataAccess.Migrations
{
    public partial class UsertableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phonenumber",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phonenumber",
                table: "Users",
                type: "text",
                nullable: true);
        }
    }
}
