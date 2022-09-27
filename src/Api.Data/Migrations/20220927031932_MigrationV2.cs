using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CURNAME",
                table: "bulletins",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "SBJNAME",
                table: "bulletins",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "STDFULLNAME",
                table: "bulletins",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "STDREGISTRATION",
                table: "bulletins",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CURNAME",
                table: "bulletins");

            migrationBuilder.DropColumn(
                name: "SBJNAME",
                table: "bulletins");

            migrationBuilder.DropColumn(
                name: "STDFULLNAME",
                table: "bulletins");

            migrationBuilder.DropColumn(
                name: "STDREGISTRATION",
                table: "bulletins");
        }
    }
}
