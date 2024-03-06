using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTreker_v1._0._2_OLYU.Migrations.GymMigrations
{
    public partial class GymMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_WorkoutSchedules_WorkoutScheduleId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_WorkoutSchedules_WorkoutScheduleId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_WorkoutScheduleId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_WorkoutScheduleId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WorkoutScheduleId",
                table: "Schedules");

            migrationBuilder.CreateTable(
                name: "ScheduleWorkoutSchedule",
                columns: table => new
                {
                    SchedulesId = table.Column<int>(type: "int", nullable: false),
                    WorkoutSchedulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleWorkoutSchedule", x => new { x.SchedulesId, x.WorkoutSchedulesId });
                    table.ForeignKey(
                        name: "FK_ScheduleWorkoutSchedule_Schedules_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleWorkoutSchedule_WorkoutSchedules_WorkoutSchedulesId",
                        column: x => x.WorkoutSchedulesId,
                        principalTable: "WorkoutSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutWorkoutSchedule",
                columns: table => new
                {
                    WorkoutSchedulesId = table.Column<int>(type: "int", nullable: false),
                    WorkoutsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutWorkoutSchedule", x => new { x.WorkoutSchedulesId, x.WorkoutsId });
                    table.ForeignKey(
                        name: "FK_WorkoutWorkoutSchedule_Workouts_WorkoutsId",
                        column: x => x.WorkoutsId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutWorkoutSchedule_WorkoutSchedules_WorkoutSchedulesId",
                        column: x => x.WorkoutSchedulesId,
                        principalTable: "WorkoutSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleWorkoutSchedule_WorkoutSchedulesId",
                table: "ScheduleWorkoutSchedule",
                column: "WorkoutSchedulesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutWorkoutSchedule_WorkoutsId",
                table: "WorkoutWorkoutSchedule",
                column: "WorkoutsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleWorkoutSchedule");

            migrationBuilder.DropTable(
                name: "WorkoutWorkoutSchedule");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutScheduleId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutScheduleId",
                table: "Workouts",
                column: "WorkoutScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_WorkoutScheduleId",
                table: "Schedules",
                column: "WorkoutScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_WorkoutSchedules_WorkoutScheduleId",
                table: "Schedules",
                column: "WorkoutScheduleId",
                principalTable: "WorkoutSchedules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_WorkoutSchedules_WorkoutScheduleId",
                table: "Workouts",
                column: "WorkoutScheduleId",
                principalTable: "WorkoutSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
