using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class HopefullytheLastone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "personalDetails");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "personalDetails",
                newName: "CVFileName");

            migrationBuilder.AddColumn<string>(
                name: "usersId",
                table: "personalDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usersId",
                table: "certificateUploads",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "IX_personalDetails_usersId",
                table: "personalDetails",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_certificateUploads_usersId",
                table: "certificateUploads",
                column: "usersId");

            migrationBuilder.AddForeignKey(
                name: "FK_certificateUploads_ApplicationUser_usersId",
                table: "certificateUploads",
                column: "usersId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personalDetails_ApplicationUser_usersId",
                table: "personalDetails",
                column: "usersId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_certificateUploads_ApplicationUser_usersId",
                table: "certificateUploads");

            migrationBuilder.DropForeignKey(
                name: "FK_personalDetails_ApplicationUser_usersId",
                table: "personalDetails");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_personalDetails_usersId",
                table: "personalDetails");

            migrationBuilder.DropIndex(
                name: "IX_certificateUploads_usersId",
                table: "certificateUploads");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "certificateUploads");

            migrationBuilder.RenameColumn(
                name: "CVFileName",
                table: "personalDetails",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "personalDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "personalDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "personalDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "personalDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
