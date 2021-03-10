using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Data.Migrations.AuthenticationDb
{
    public partial class okayitcanonlygetbetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "AspNetUsers");
        }
    }
}
