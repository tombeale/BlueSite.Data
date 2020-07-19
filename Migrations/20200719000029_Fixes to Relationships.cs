using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class FixestoRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(maxLength: 20, nullable: true),
                    Type = table.Column<string>(maxLength: 20, nullable: true),
                    ContactId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phones_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPhones",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false),
                    CompanyId2 = table.Column<int>(nullable: true)
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
                        name: "FK_CompanyPhones_Companies_CompanyId2",
                        column: x => x.CompanyId2,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyPhones_Companies_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactPhones",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPhones", x => new { x.ContactId, x.PhoneId });
                    table.ForeignKey(
                        name: "FK_ContactPhones_Phones_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactPhones_Contacts_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ContactId",
                table: "Notes",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ContactId",
                table: "Companies",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPhones_CompanyId2",
                table: "CompanyPhones",
                column: "CompanyId2");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPhones_PhoneId",
                table: "CompanyPhones",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhones_PhoneId",
                table: "ContactPhones",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CompanyId",
                table: "Phones",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ContactId",
                table: "Phones",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Contacts_ContactId",
                table: "Companies",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Contacts_ContactId",
                table: "Notes",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Contacts_ContactId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Contacts_ContactId",
                table: "Notes");

            migrationBuilder.DropTable(
                name: "CompanyPhones");

            migrationBuilder.DropTable(
                name: "ContactPhones");

            migrationBuilder.DropTable(
                name: "PhoneTypes");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ContactId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ContactId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Companies");
        }
    }
}
