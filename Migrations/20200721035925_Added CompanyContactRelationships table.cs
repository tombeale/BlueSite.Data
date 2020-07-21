using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedCompanyContactRelationshipstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyContactRelationships",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContactRelationships", x => new { x.CompanyId, x.ContactId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContactRelationships");
        }
    }
}
