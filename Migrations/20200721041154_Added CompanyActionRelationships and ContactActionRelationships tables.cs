using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedCompanyActionRelationshipsandContactActionRelationshipstables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyActionRelationship",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: true),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyActionRelationship", x => new { x.CompanyId, x.ActionId });
                    table.UniqueConstraint("AK_CompanyActionRelationship_ActionId_CompanyId", x => new { x.ActionId, x.CompanyId });
                });

            migrationBuilder.CreateTable(
                name: "ContactActionRelationship",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: true),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactActionRelationship", x => new { x.ContactId, x.ActionId });
                    table.UniqueConstraint("AK_ContactActionRelationship_ActionId_ContactId", x => new { x.ActionId, x.ContactId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyActionRelationship");

            migrationBuilder.DropTable(
                name: "ContactActionRelationship");
        }
    }
}
