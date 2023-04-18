using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdaArquiteturaAPI.Migrations
{
    public partial class AdicionandoRelacionamentoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "projectId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_userId",
                table: "Projects",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_userId",
                table: "Projects",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_userId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_userId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "projectId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
