using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class _42thConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_OwnerId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTitle_AspNetUsers_OwnerId",
                table: "ForumTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_AspNetUsers_OwnerId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_OwnerId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_AspNetUsers_OwnerId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_AuthorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComment_AspNetUsers_OwnerId",
                table: "ProductComment");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccess_AspNetRoles_RoleId",
                table: "RoleAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_AspNetUsers_OwnerId",
                table: "Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCart_AspNetUsers_OwnerId",
                table: "UserCart");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_AspNetUsers_UserId",
                table: "UserToken");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_UserCart_OwnerId",
                table: "UserCart");

            migrationBuilder.DropIndex(
                name: "IX_Tag_OwnerId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_ProductCallRequest_UserId",
                table: "ProductCallRequest");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_OwnerId",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_OwnerId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_ForumTitle_OwnerId",
                table: "ForumTitle");

            migrationBuilder.DropIndex(
                name: "IX_ForumComment_UserId",
                table: "ForumComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "IdentityUserToken<int>");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "IdentityUserRole<int>");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "IdentityUserLogin<int>");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "IdentityUserClaim<int>");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "IdentityRoleClaim<int>");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "IdentityUserRole<int>",
                newName: "IX_IdentityUserRole<int>_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "IdentityUserLogin<int>",
                newName: "IX_IdentityUserLogin<int>_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "IdentityUserClaim<int>",
                newName: "IX_IdentityUserClaim<int>_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "IdentityRoleClaim<int>",
                newName: "IX_IdentityRoleClaim<int>_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserToken<int>",
                table: "IdentityUserToken<int>",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRole<int>",
                table: "IdentityUserRole<int>",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserLogin<int>",
                table: "IdentityUserLogin<int>",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserClaim<int>",
                table: "IdentityUserClaim<int>",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRoleClaim<int>",
                table: "IdentityRoleClaim<int>",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "ApplicationRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_ApplicationUser_OwnerId",
                table: "Address",
                column: "OwnerId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<int>_ApplicationRole_RoleId",
                table: "IdentityRoleClaim<int>",
                column: "RoleId",
                principalTable: "ApplicationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<int>_ApplicationUser_UserId",
                table: "IdentityUserClaim<int>",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<int>_ApplicationUser_UserId",
                table: "IdentityUserLogin<int>",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<int>_ApplicationRole_RoleId",
                table: "IdentityUserRole<int>",
                column: "RoleId",
                principalTable: "ApplicationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<int>_ApplicationUser_UserId",
                table: "IdentityUserRole<int>",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserToken<int>_ApplicationUser_UserId",
                table: "IdentityUserToken<int>",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_ApplicationUser_OwnerId",
                table: "Post",
                column: "OwnerId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ApplicationUser_AuthorId",
                table: "Product",
                column: "AuthorId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComment_ApplicationUser_OwnerId",
                table: "ProductComment",
                column: "OwnerId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccess_ApplicationRole_RoleId",
                table: "RoleAccess",
                column: "RoleId",
                principalTable: "ApplicationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_ApplicationUser_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_ApplicationUser_OwnerId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityRoleClaim<int>_ApplicationRole_RoleId",
                table: "IdentityRoleClaim<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserClaim<int>_ApplicationUser_UserId",
                table: "IdentityUserClaim<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserLogin<int>_ApplicationUser_UserId",
                table: "IdentityUserLogin<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<int>_ApplicationRole_RoleId",
                table: "IdentityUserRole<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<int>_ApplicationUser_UserId",
                table: "IdentityUserRole<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserToken<int>_ApplicationUser_UserId",
                table: "IdentityUserToken<int>");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_ApplicationUser_OwnerId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ApplicationUser_AuthorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComment_ApplicationUser_OwnerId",
                table: "ProductComment");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccess_ApplicationRole_RoleId",
                table: "RoleAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_ApplicationUser_UserId",
                table: "UserToken");

            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserToken<int>",
                table: "IdentityUserToken<int>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRole<int>",
                table: "IdentityUserRole<int>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserLogin<int>",
                table: "IdentityUserLogin<int>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserClaim<int>",
                table: "IdentityUserClaim<int>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRoleClaim<int>",
                table: "IdentityRoleClaim<int>");

            migrationBuilder.RenameTable(
                name: "IdentityUserToken<int>",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "IdentityUserRole<int>",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "IdentityUserLogin<int>",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "IdentityUserClaim<int>",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "IdentityRoleClaim<int>",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserRole<int>_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserLogin<int>_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserClaim<int>_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityRoleClaim<int>_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCart_OwnerId",
                table: "UserCart",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_OwnerId",
                table: "Tag",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCallRequest_UserId",
                table: "ProductCallRequest",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_OwnerId",
                table: "PostComment",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OwnerId",
                table: "Payment",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTitle_OwnerId",
                table: "ForumTitle",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComment_UserId",
                table: "ForumComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_OwnerId",
                table: "Address",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumComment_AspNetUsers_UserId",
                table: "ForumComment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumTitle_AspNetUsers_OwnerId",
                table: "ForumTitle",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_AspNetUsers_OwnerId",
                table: "Payment",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_OwnerId",
                table: "Post",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_AspNetUsers_OwnerId",
                table: "PostComment",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_AuthorId",
                table: "Product",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCallRequest_AspNetUsers_UserId",
                table: "ProductCallRequest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComment_AspNetUsers_OwnerId",
                table: "ProductComment",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccess_AspNetRoles_RoleId",
                table: "RoleAccess",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_AspNetUsers_OwnerId",
                table: "Tag",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCart_AspNetUsers_OwnerId",
                table: "UserCart",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_AspNetUsers_UserId",
                table: "UserToken",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
