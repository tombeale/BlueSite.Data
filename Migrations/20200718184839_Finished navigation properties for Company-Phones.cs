using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class FinishednavigationpropertiesforCompanyPhones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Companies_CompanyId1",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CompanyId1",
                table: "Phones");

            migrationBuilder.RenameColumn(
                name: "CompanyId1",
                table: "Phones",
                newName: "ContactId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Phones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyPhones",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPhones", x => new { x.CompanyId, x.PhoneId });
                    table.ForeignKey(
                        name: "FK_CompanyPhones_Phones_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyPhones_Companies_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CompanyId",
                table: "Phones",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPhones_PhoneId",
                table: "CompanyPhones",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Companies_CompanyId",
                table: "Phones",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Companies_CompanyId",
                table: "Phones");

            migrationBuilder.DropTable(
                name: "CompanyPhones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CompanyId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Phones");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Phones",
                newName: "CompanyId1");

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
    }
}
