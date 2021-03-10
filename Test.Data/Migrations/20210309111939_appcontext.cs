using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations
{
    public partial class appcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certificateUploads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionalCertFileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalCertFileName = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BscCertFileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BscCertFileName = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    WaecCertFileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaecCertFileName = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificateUploads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVFileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVFiles = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "certificateUploads");

            migrationBuilder.DropTable(
                name: "personalDetails");
        }
    }
}
