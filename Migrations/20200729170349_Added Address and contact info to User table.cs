using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedAddressandcontactinfotoUsertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Users",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Users",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Users",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Users",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Users");
        }
    }
}
