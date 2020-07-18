using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class Addedforeignkeyandnavigationpropertiesforcompanyphones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Phones",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Phones",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId1",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CompanyId1",
                table: "Phones",
                column: "CompanyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Companies_CompanyId1",
                table: "Phones",
                column: "CompanyId1",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Companies_CompanyId1",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CompanyId1",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CompanyId1",
                table: "Phones");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Phones",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Number");
        }
    }
}
