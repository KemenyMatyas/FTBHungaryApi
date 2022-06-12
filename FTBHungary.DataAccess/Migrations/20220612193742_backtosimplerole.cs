using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FTBHungary.DataAccess.Migrations
{
    public partial class backtosimplerole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.AddColumn<Guid>(
                name: "UserRoleGuid",
                table: "Users",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleGuid",
                table: "Users",
                column: "UserRoleGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_UserRoleGuid",
                table: "Users",
                column: "UserRoleGuid",
                principalTable: "Roles",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_UserRoleGuid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserRoleGuid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRoleGuid",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleGuid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserGuid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_UserRole_Roles_RoleGuid",
                        column: x => x.RoleGuid,
                        principalTable: "Roles",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleGuid",
                table: "UserRole",
                column: "RoleGuid");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserGuid_RoleGuid",
                table: "UserRole",
                columns: new[] { "UserGuid", "RoleGuid" },
                unique: true);
        }
    }
}
