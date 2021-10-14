using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityManagement.Migrations
{
    public partial class AddHasScoreChecked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasScoreChecked",
                table: "StudentActivities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasScoreChecked",
                table: "StudentActivities");
        }
    }
}
