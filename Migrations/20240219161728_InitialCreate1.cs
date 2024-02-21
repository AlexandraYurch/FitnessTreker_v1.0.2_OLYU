using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTreker_v1._0._2_OLYU.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndWHString",
                table: "WorkoutSchedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartWHString",
                table: "WorkoutSchedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWHString",
                table: "WorkoutSchedules");

            migrationBuilder.DropColumn(
                name: "StartWHString",
                table: "WorkoutSchedules");
        }
    }
}
