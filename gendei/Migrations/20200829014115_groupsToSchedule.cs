using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class groupsToSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_AttendantId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_ClientId",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Schedule");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_ClientId",
                table: "Schedule",
                newName: "IX_Schedule_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_AttendantId",
                table: "Schedule",
                newName: "IX_Schedule_AttendantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Users_AttendantId",
                table: "Schedule",
                column: "AttendantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Users_ClientId",
                table: "Schedule",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Users_AttendantId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Users_ClientId",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_ClientId",
                table: "Groups",
                newName: "IX_Groups_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_AttendantId",
                table: "Groups",
                newName: "IX_Groups_AttendantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_AttendantId",
                table: "Groups",
                column: "AttendantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_ClientId",
                table: "Groups",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
