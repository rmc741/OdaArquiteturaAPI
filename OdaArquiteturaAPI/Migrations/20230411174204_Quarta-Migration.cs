using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdaArquiteturaAPI.Migrations
{
    public partial class QuartaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Projects");
        }
    }
}
