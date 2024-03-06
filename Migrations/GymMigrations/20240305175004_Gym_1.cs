using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTreker_v1._0._2_OLYU.Migrations.GymMigrations
{
    public partial class Gym_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsVisited = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramId = table.Column<int>(type: "int", nullable: false),
                    VisitingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Visitings_VisitingsId",
                        column: x => x.VisitingsId,
                        principalTable: "Visitings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutId = table.Column<int>(type: "int", nullable: false),
                    VisitingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutSchedules_Visitings_VisitingId",
                        column: x => x.VisitingId,
                        principalTable: "Visitings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartEndWH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkoutScheduleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_WorkoutSchedules_WorkoutScheduleId",
                        column: x => x.WorkoutScheduleId,
                        principalTable: "WorkoutSchedules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_WorkoutSchedules_WorkoutScheduleId",
                        column: x => x.WorkoutScheduleId,
                        principalTable: "WorkoutSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_WorkoutScheduleId",
                table: "Schedules",
                column: "WorkoutScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_VisitingsId",
                table: "Users",
                column: "VisitingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutScheduleId",
                table: "Workouts",
                column: "WorkoutScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSchedules_VisitingId",
                table: "WorkoutSchedules",
                column: "VisitingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "WorkoutSchedules");

            migrationBuilder.DropTable(
                name: "Visitings");
        }
    }
}
