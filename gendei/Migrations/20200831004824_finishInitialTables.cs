using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace gendei.Migrations
{
    public partial class finishInitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_User_AttendantId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_User_ClientId",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Schedule");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "schedule");

            migrationBuilder.RenameColumn(
                name: "Observation",
                table: "schedule",
                newName: "observation");

            migrationBuilder.RenameColumn(
                name: "Canceled",
                table: "schedule",
                newName: "canceled");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "schedule",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "schedule",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "RegisterDate",
                table: "schedule",
                newName: "register_date");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "schedule",
                newName: "end_time");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "schedule",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "CanceledReason",
                table: "schedule",
                newName: "canceled_reason");

            migrationBuilder.RenameColumn(
                name: "AttendantId",
                table: "schedule",
                newName: "attendant_id");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "schedule",
                newName: "appointment_date");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_ClientId",
                table: "schedule",
                newName: "IX_schedule_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_AttendantId",
                table: "schedule",
                newName: "IX_schedule_attendant_id");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "start_time",
                table: "schedule",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<DateTime>(
                name: "register_date",
                table: "schedule",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "end_time",
                table: "schedule",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<string>(
                name: "canceled_reason",
                table: "schedule",
                type: "character varying",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "appointment_date",
                table: "schedule",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Address",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedule",
                table: "schedule",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsMainContact = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleConfig",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: true),
                    EndTime = table.Column<TimeSpan>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true),
                    DayOfWeek = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleConfig", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleConfig_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: false),
                    AuthDate = table.Column<DateTime>(nullable: false),
                    LastToken = table.Column<string>(nullable: true),
                    TokenRefreshDate = table.Column<DateTime>(nullable: false),
                    RefreshTokenCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendantServiceRel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceId = table.Column<int>(nullable: false),
                    AttendantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendantServiceRel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendantServiceRel_User_AttendantId",
                        column: x => x.AttendantId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendantServiceRel_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "schedule_id_uindex",
                table: "schedule",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendantServiceRel_AttendantId",
                table: "AttendantServiceRel",
                column: "AttendantId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendantServiceRel_ServiceId",
                table: "AttendantServiceRel",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserId",
                table: "Contact",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleConfig_UserId",
                table: "ScheduleConfig",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_UserId",
                table: "Session",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "schedule_user_doctor_id_fk",
                table: "schedule",
                column: "attendant_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "schedule_user_patient_id_fk",
                table: "schedule",
                column: "client_id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "schedule_user_doctor_id_fk",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "schedule_user_patient_id_fk",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropTable(
                name: "AttendantServiceRel");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "ScheduleConfig");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schedule",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "schedule_id_uindex",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "schedule",
                newName: "Schedule");

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
                name: "IX_schedule_client_id",
                table: "Schedule",
                newName: "IX_Schedule_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_attendant_id",
                table: "Schedule",
                newName: "IX_Schedule_AttendantId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Schedule",
                type: "interval",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Schedule",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Schedule",
                type: "interval",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CanceledReason",
                table: "Schedule",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Schedule",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Schedule",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_User_AttendantId",
                table: "Schedule",
                column: "AttendantId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_User_ClientId",
                table: "Schedule",
                column: "ClientId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
