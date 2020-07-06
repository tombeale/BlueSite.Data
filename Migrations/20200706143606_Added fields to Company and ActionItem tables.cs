using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedfieldstoCompanyandActionItemtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Companies",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Companies",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Companies",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent",
                table: "ActionItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "ActionItems");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Companies",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
