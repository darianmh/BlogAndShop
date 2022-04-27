using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _41thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegisterDescription",
                table: "CourseRegisterRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisterDescription",
                table: "CourseRegisterRequest");
        }
    }
}
