using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BlogAndShop.Migrations
{
    public partial class _11thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumGroupId",
                table: "ForumTitle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ForumGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumGroup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumTitle_ForumGroupId",
                table: "ForumTitle",
                column: "ForumGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTitle_ForumGroup_ForumGroupId",
                table: "ForumTitle",
                column: "ForumGroupId",
                principalTable: "ForumGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumTitle_ForumGroup_ForumGroupId",
                table: "ForumTitle");

            migrationBuilder.DropTable(
                name: "ForumGroup");

            migrationBuilder.DropIndex(
                name: "IX_ForumTitle_ForumGroupId",
                table: "ForumTitle");

            migrationBuilder.DropColumn(
                name: "ForumGroupId",
                table: "ForumTitle");
        }
    }
}
