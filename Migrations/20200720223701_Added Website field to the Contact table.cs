using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedWebsitefieldtotheContacttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Contacts",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Website",
                table: "Contacts");
        }
    }
}
