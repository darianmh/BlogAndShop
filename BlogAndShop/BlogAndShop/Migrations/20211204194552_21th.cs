using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _21th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTag",
                table: "ProductTag");

            migrationBuilder.DropIndex(
                name: "IX_ProductTag_ProductId",
                table: "ProductTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMedia",
                table: "ProductMedia");

            migrationBuilder.DropIndex(
                name: "IX_ProductMedia_ProductId",
                table: "ProductMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_Tags",
                table: "Post_Tags");

            migrationBuilder.DropIndex(
                name: "IX_Post_Tags_TagId",
                table: "Post_Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_PostGroup",
                table: "Post_PostGroup");

            migrationBuilder.DropIndex(
                name: "IX_Post_PostGroup_GroupId",
                table: "Post_PostGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTag",
                table: "ProductTag",
                columns: new[] { "ProductId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMedia",
                table: "ProductMedia",
                columns: new[] { "ProductId", "MediaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_Tags",
                table: "Post_Tags",
                columns: new[] { "TagId", "PostId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_PostGroup",
                table: "Post_PostGroup",
                columns: new[] { "GroupId", "PostId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_TagId",
                table: "ProductTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_MediaId",
                table: "ProductMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tags_PostId",
                table: "Post_Tags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostGroup_PostId",
                table: "Post_PostGroup",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTag",
                table: "ProductTag");

            migrationBuilder.DropIndex(
                name: "IX_ProductTag_TagId",
                table: "ProductTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMedia",
                table: "ProductMedia");

            migrationBuilder.DropIndex(
                name: "IX_ProductMedia_MediaId",
                table: "ProductMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_Tags",
                table: "Post_Tags");

            migrationBuilder.DropIndex(
                name: "IX_Post_Tags_PostId",
                table: "Post_Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post_PostGroup",
                table: "Post_PostGroup");

            migrationBuilder.DropIndex(
                name: "IX_Post_PostGroup_PostId",
                table: "Post_PostGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTag",
                table: "ProductTag",
                column: "TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMedia",
                table: "ProductMedia",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_Tags",
                table: "Post_Tags",
                column: "PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post_PostGroup",
                table: "Post_PostGroup",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_ProductId",
                table: "ProductTag",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_ProductId",
                table: "ProductMedia",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tags_TagId",
                table: "Post_Tags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostGroup_GroupId",
                table: "Post_PostGroup",
                column: "GroupId");
        }
    }
}
