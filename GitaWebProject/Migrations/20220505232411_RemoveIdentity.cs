using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitaWebProject.Migrations
{
    public partial class RemoveIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeletedProducts_Users_CreatedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_DeletedProducts_Users_DeletedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_DeletedProducts_Users_ModifiedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChanges_Users_CreatedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChanges_Users_DeletedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_UserChanges_Users_ModifiedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Production");

            migrationBuilder.DropIndex(
                name: "IX_UserChanges_CreatedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropIndex(
                name: "IX_UserChanges_DeletedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropIndex(
                name: "IX_UserChanges_ModifiedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropIndex(
                name: "IX_DeletedProducts_CreatedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropIndex(
                name: "IX_DeletedProducts_DeletedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropIndex(
                name: "IX_DeletedProducts_ModifiedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                schema: "Production",
                table: "UserChanges");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                schema: "Production",
                table: "DeletedProducts");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                schema: "Production",
                table: "DeletedProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                schema: "Production",
                table: "UserChanges",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedById",
                schema: "Production",
                table: "UserChanges",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                schema: "Production",
                table: "UserChanges",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                schema: "Production",
                table: "DeletedProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedById",
                schema: "Production",
                table: "DeletedProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedById",
                schema: "Production",
                table: "DeletedProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Production",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Production",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Production",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Production",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Production",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Production",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Production",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Production",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Production",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserChanges_CreatedById",
                schema: "Production",
                table: "UserChanges",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserChanges_DeletedById",
                schema: "Production",
                table: "UserChanges",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserChanges_ModifiedById",
                schema: "Production",
                table: "UserChanges",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DeletedProducts_CreatedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DeletedProducts_DeletedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_DeletedProducts_ModifiedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Production",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Production",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Production",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Production",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Production",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Production",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Production",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DeletedProducts_Users_CreatedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "CreatedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeletedProducts_Users_DeletedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "DeletedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeletedProducts_Users_ModifiedById",
                schema: "Production",
                table: "DeletedProducts",
                column: "ModifiedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChanges_Users_CreatedById",
                schema: "Production",
                table: "UserChanges",
                column: "CreatedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChanges_Users_DeletedById",
                schema: "Production",
                table: "UserChanges",
                column: "DeletedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChanges_Users_ModifiedById",
                schema: "Production",
                table: "UserChanges",
                column: "ModifiedById",
                principalSchema: "Production",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
