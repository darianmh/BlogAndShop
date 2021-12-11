using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _29thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_PostComment_ParentId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostGroup_PostGroup_ParentId",
                table: "PostGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComment_ProductComment_ParentId",
                table: "ProductComment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductForumInfos_ForumTitle_ForumTitleId",
                table: "ProductForumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductForumInfos_Product_ProductId",
                table: "ProductForumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_ProductGroup_ParentId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_ParentId",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductComment_ParentId",
                table: "ProductComment");

            migrationBuilder.DropIndex(
                name: "IX_PostGroup_ParentId",
                table: "PostGroup");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_ParentId",
                table: "PostComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductForumInfos",
                table: "ProductForumInfos");

            migrationBuilder.RenameTable(
                name: "ProductForumInfos",
                newName: "Product_ForumInfo");

            migrationBuilder.RenameIndex(
                name: "IX_ProductForumInfos_ForumTitleId",
                table: "Product_ForumInfo",
                newName: "IX_Product_ForumInfo_ForumTitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product_ForumInfo",
                table: "Product_ForumInfo",
                columns: new[] { "ProductId", "ForumTitleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ForumInfo_ForumTitle_ForumTitleId",
                table: "Product_ForumInfo",
                column: "ForumTitleId",
                principalTable: "ForumTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ForumInfo_Product_ProductId",
                table: "Product_ForumInfo",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ForumInfo_ForumTitle_ForumTitleId",
                table: "Product_ForumInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ForumInfo_Product_ProductId",
                table: "Product_ForumInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product_ForumInfo",
                table: "Product_ForumInfo");

            migrationBuilder.RenameTable(
                name: "Product_ForumInfo",
                newName: "ProductForumInfos");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ForumInfo_ForumTitleId",
                table: "ProductForumInfos",
                newName: "IX_ProductForumInfos_ForumTitleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductForumInfos",
                table: "ProductForumInfos",
                columns: new[] { "ProductId", "ForumTitleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroup_ParentId",
                table: "ProductGroup",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_ParentId",
                table: "ProductComment",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PostGroup_ParentId",
                table: "PostGroup",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_ParentId",
                table: "PostComment",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_PostComment_ParentId",
                table: "PostComment",
                column: "ParentId",
                principalTable: "PostComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostGroup_PostGroup_ParentId",
                table: "PostGroup",
                column: "ParentId",
                principalTable: "PostGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComment_ProductComment_ParentId",
                table: "ProductComment",
                column: "ParentId",
                principalTable: "ProductComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductForumInfos_ForumTitle_ForumTitleId",
                table: "ProductForumInfos",
                column: "ForumTitleId",
                principalTable: "ForumTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductForumInfos_Product_ProductId",
                table: "ProductForumInfos",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductGroup_ProductGroup_ParentId",
                table: "ProductGroup",
                column: "ParentId",
                principalTable: "ProductGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
