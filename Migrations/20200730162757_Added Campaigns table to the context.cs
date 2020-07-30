using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedCampaignstabletothecontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CampaignId",
                table: "Contacts",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionItems_CampaignId",
                table: "ActionItems",
                column: "CampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionItems_Campaigns_CampaignId",
                table: "ActionItems",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "CampaignId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Campaigns_CampaignId",
                table: "Contacts",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "CampaignId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionItems_Campaigns_CampaignId",
                table: "ActionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Campaigns_CampaignId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CampaignId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_ActionItems_CampaignId",
                table: "ActionItems");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Contacts");
        }
    }
}
