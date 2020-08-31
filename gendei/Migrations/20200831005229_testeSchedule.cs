using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class testeSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "schedule_user_doctor_id_fk",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "schedule_user_patient_id_fk",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "schedule_id_uindex",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "observation",
                table: "Schedule",
                newName: "Observation");

            migrationBuilder.RenameColumn(
                name: "canceled",
                table: "Schedule",
                newName: "Canceled");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Schedule",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "Schedule",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "register_date",
                table: "Schedule",
                newName: "RegisterDate");

            migrationBuilder.RenameColumn(
                name: "end_time",
                table: "Schedule",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "Schedule",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "canceled_reason",
                table: "Schedule",
                newName: "CanceledReason");

            migrationBuilder.RenameColumn(
                name: "attendant_id",
                table: "Schedule",
                newName: "AttendantId");

            migrationBuilder.RenameColumn(
                name: "appointment_date",
                table: "Schedule",
                newName: "AppointmentDate");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_client_id",
                table: "Schedule",
                newName: "IX_Schedule_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_attendant_id",
                table: "Schedule",
                newName: "IX_Schedule_AttendantId");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CanceledReason",
                table: "Schedule",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "schedule_user_attendant_id_fk",
                table: "Schedule",
                column: "AttendantId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "schedule_user_client_id_fk",
                table: "Schedule",
                column: "ClientId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "schedule_user_attendant_id_fk",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "schedule_user_client_id_fk",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "Observation",
                table: "Schedule",
                newName: "observation");

            migrationBuilder.RenameColumn(
                name: "Canceled",
                table: "Schedule",
                newName: "canceled");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schedule",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Schedule",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "RegisterDate",
                table: "Schedule",
                newName: "register_date");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Schedule",
                newName: "end_time");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Schedule",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "CanceledReason",
                table: "Schedule",
                newName: "canceled_reason");

            migrationBuilder.RenameColumn(
                name: "AttendantId",
                table: "Schedule",
                newName: "attendant_id");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Schedule",
                newName: "appointment_date");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_ClientId",
                table: "Schedule",
                newName: "IX_Schedule_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_AttendantId",
                table: "Schedule",
                newName: "IX_Schedule_attendant_id");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "start_time",
                table: "Schedule",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "register_date",
                table: "Schedule",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "end_time",
                table: "Schedule",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<string>(
                name: "canceled_reason",
                table: "Schedule",
                type: "character varying",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "appointment_date",
                table: "Schedule",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "schedule_id_uindex",
                table: "Schedule",
                column: "id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "schedule_user_doctor_id_fk",
                table: "Schedule",
                column: "attendant_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "schedule_user_patient_id_fk",
                table: "Schedule",
                column: "client_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
