using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDL.Migrations
{
    public partial class RelationshipFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskName",
                table: "Stuffs",
                newName: "StuffStatus");

            migrationBuilder.RenameColumn(
                name: "TaksDescription",
                table: "Stuffs",
                newName: "StuffName");

            migrationBuilder.AddColumn<string>(
                name: "StuffDescription",
                table: "Stuffs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Stuffs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StuffDescription",
                table: "Stuffs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stuffs");

            migrationBuilder.RenameColumn(
                name: "StuffStatus",
                table: "Stuffs",
                newName: "TaskName");

            migrationBuilder.RenameColumn(
                name: "StuffName",
                table: "Stuffs",
                newName: "TaksDescription");
        }
    }
}
