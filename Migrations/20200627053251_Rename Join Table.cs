using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSite.Data.Migrations
{
    public partial class RenameJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionNotes_Notes_ActionItemId",
                table: "ActionNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ActionNotes_ActionItems_NoteId",
                table: "ActionNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionNotes",
                table: "ActionNotes");

            migrationBuilder.RenameTable(
                name: "ActionNotes",
                newName: "ActionItemNotes");

            migrationBuilder.RenameIndex(
                name: "IX_ActionNotes_NoteId",
                table: "ActionItemNotes",
                newName: "IX_ActionItemNotes_NoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionItemNotes",
                table: "ActionItemNotes",
                columns: new[] { "ActionItemId", "NoteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ActionItemNotes_Notes_ActionItemId",
                table: "ActionItemNotes",
                column: "ActionItemId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionItemNotes_ActionItems_NoteId",
                table: "ActionItemNotes",
                column: "NoteId",
                principalTable: "ActionItems",
                principalColumn: "ActionItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionItemNotes_Notes_ActionItemId",
                table: "ActionItemNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ActionItemNotes_ActionItems_NoteId",
                table: "ActionItemNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionItemNotes",
                table: "ActionItemNotes");

            migrationBuilder.RenameTable(
                name: "ActionItemNotes",
                newName: "ActionNotes");

            migrationBuilder.RenameIndex(
                name: "IX_ActionItemNotes_NoteId",
                table: "ActionNotes",
                newName: "IX_ActionNotes_NoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionNotes",
                table: "ActionNotes",
                columns: new[] { "ActionItemId", "NoteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ActionNotes_Notes_ActionItemId",
                table: "ActionNotes",
                column: "ActionItemId",
                principalTable: "Notes",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionNotes_ActionItems_NoteId",
                table: "ActionNotes",
                column: "NoteId",
                principalTable: "ActionItems",
                principalColumn: "ActionItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
