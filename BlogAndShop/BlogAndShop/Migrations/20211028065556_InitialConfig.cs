using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAndShop.Migrations
{
    public partial class InitialConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
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
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alley = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ForumId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumTitle_OwnerId = table.Column<int>(type: "int", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Media_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Media_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_OwnerId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OffAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Payment_Status = table.Column<int>(type: "int", nullable: true),
                    Payment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    PaymentItem_ProductId = table.Column<int>(type: "int", nullable: true),
                    PaymentItem_Quantity = table.Column<int>(type: "int", nullable: true),
                    PaymentItem_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentItem_OffAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentLog_PaymentId = table.Column<int>(type: "int", nullable: true),
                    PaymentLog_Status = table.Column<int>(type: "int", nullable: true),
                    PaymentLog_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_OwnerId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PostComment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostComment_OwnerId = table.Column<int>(type: "int", nullable: true),
                    PostComment_IsAccepted = table.Column<bool>(type: "bit", nullable: true),
                    PostGroup_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostGroup_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_BannerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    ProductGroupId = table.Column<int>(type: "int", nullable: true),
                    OffPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductComment_ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductComment_ParentId = table.Column<int>(type: "int", nullable: true),
                    ProductComment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductComment_OwnerId = table.Column<int>(type: "int", nullable: true),
                    ProductComment_IsAccepted = table.Column<bool>(type: "bit", nullable: true),
                    ProductGroup_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductGroup_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductGroup_ParentId = table.Column<int>(type: "int", nullable: true),
                    AttrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    SiteConfig_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteConfig_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag_OwnerId = table.Column<int>(type: "int", nullable: true),
                    Tag_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCart_OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_ForumTitle_OwnerId",
                        column: x => x.ForumTitle_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_Payment_OwnerId",
                        column: x => x.Payment_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_Post_OwnerId",
                        column: x => x.Post_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_PostComment_OwnerId",
                        column: x => x.PostComment_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_ProductComment_OwnerId",
                        column: x => x.ProductComment_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_Tag_OwnerId",
                        column: x => x.Tag_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_UserCart_OwnerId",
                        column: x => x.UserCart_OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_AddressId",
                        column: x => x.AddressId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_CartId",
                        column: x => x.CartId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ForumId",
                        column: x => x.ForumId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PaymentItem_ProductId",
                        column: x => x.PaymentItem_ProductId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PaymentLog_PaymentId",
                        column: x => x.PaymentLog_PaymentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PostId",
                        column: x => x.PostId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProductComment_ParentId",
                        column: x => x.ProductComment_ParentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProductComment_ProductId",
                        column: x => x.ProductComment_ProductId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProductGroup_ParentId",
                        column: x => x.ProductGroup_ParentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post_PostGroup",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_PostGroup", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_PostGroup_BaseEntity_GroupId",
                        column: x => x.GroupId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_PostGroup_BaseEntity_PostId",
                        column: x => x.PostId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post_Tags",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Tags", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_Tags_BaseEntity_PostId",
                        column: x => x.PostId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Tags_BaseEntity_TagId",
                        column: x => x.TagId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMedia",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMedia", x => x.MediaId);
                    table.ForeignKey(
                        name: "FK_ProductMedia_BaseEntity_MediaId",
                        column: x => x.MediaId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductMedia_BaseEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_ProductTag_BaseEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTag_BaseEntity_TagId",
                        column: x => x.TagId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

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

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_AddressId",
                table: "BaseEntity",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_AuthorId",
                table: "BaseEntity",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CartId",
                table: "BaseEntity",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ForumId",
                table: "BaseEntity",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ForumTitle_OwnerId",
                table: "BaseEntity",
                column: "ForumTitle_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OwnerId",
                table: "BaseEntity",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ParentId",
                table: "BaseEntity",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Payment_OwnerId",
                table: "BaseEntity",
                column: "Payment_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PaymentId",
                table: "BaseEntity",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PaymentItem_ProductId",
                table: "BaseEntity",
                column: "PaymentItem_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PaymentLog_PaymentId",
                table: "BaseEntity",
                column: "PaymentLog_PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Post_OwnerId",
                table: "BaseEntity",
                column: "Post_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PostComment_OwnerId",
                table: "BaseEntity",
                column: "PostComment_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PostId",
                table: "BaseEntity",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductComment_OwnerId",
                table: "BaseEntity",
                column: "ProductComment_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductComment_ParentId",
                table: "BaseEntity",
                column: "ProductComment_ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductComment_ProductId",
                table: "BaseEntity",
                column: "ProductComment_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductGroup_ParentId",
                table: "BaseEntity",
                column: "ProductGroup_ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductGroupId",
                table: "BaseEntity",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProductId",
                table: "BaseEntity",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_RoleId",
                table: "BaseEntity",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Tag_OwnerId",
                table: "BaseEntity",
                column: "Tag_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserCart_OwnerId",
                table: "BaseEntity",
                column: "UserCart_OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostGroup_GroupId",
                table: "Post_PostGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Tags_TagId",
                table: "Post_Tags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMedia_ProductId",
                table: "ProductMedia",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_ProductId",
                table: "ProductTag",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Post_PostGroup");

            migrationBuilder.DropTable(
                name: "Post_Tags");

            migrationBuilder.DropTable(
                name: "ProductMedia");

            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropTable(
                name: "BaseEntity");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
