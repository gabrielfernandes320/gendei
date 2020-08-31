using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class updateScheduleTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_schedule",
                table: "schedule");

            migrationBuilder.RenameTable(
                name: "schedule",
                newName: "Schedule");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_client_id",
                table: "Schedule",
                newName: "IX_Schedule_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_attendant_id",
                table: "Schedule",
                newName: "IX_Schedule_attendant_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "schedule");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_client_id",
                table: "schedule",
                newName: "IX_schedule_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_attendant_id",
                table: "schedule",
                newName: "IX_schedule_attendant_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedule",
                table: "schedule",
                column: "id");
        }
    }
}
