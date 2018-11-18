using Microsoft.EntityFrameworkCore.Migrations;

namespace Collaboo.App.WebAPI.Migrations
{
    public partial class SomeMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMember_UserId",
                table: "ProjectMember",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMember_UserId",
                table: "ProjectMember");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Users");
        }
    }
}
