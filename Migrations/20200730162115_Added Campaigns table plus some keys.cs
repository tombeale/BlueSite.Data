using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedCampaignstableplussomekeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ActionItems",
                newName: "ContactId");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "ActionItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "ActionItems");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "ActionItems",
                newName: "ProjectId");
        }
    }
}
