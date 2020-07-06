using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class ChangestoNoteEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Notes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Notes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
