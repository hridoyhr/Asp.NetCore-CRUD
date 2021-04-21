using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentCRUD.Migrations
{
    public partial class StudentInitialModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "studentModels",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "studentModels");
        }
    }
}
