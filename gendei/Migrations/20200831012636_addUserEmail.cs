using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gendei.Migrations
{
    public partial class addUserEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ScheduleConfig");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "ScheduleConfig",
                type: "interval",
                nullable: true);
        }
    }
}
