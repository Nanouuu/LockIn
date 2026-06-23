using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LockInCoachWebApp.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_553 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TargetMuscle",
                table: "Exercise",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TargetMuscle",
                table: "Exercise",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
