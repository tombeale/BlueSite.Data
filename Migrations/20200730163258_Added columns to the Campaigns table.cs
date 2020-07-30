using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class AddedcolumnstotheCampaignstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Campaigns",
                maxLength: 160,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefNumber",
                table: "Campaigns",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Campaigns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "RefNumber",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Campaigns");
        }
    }
}
