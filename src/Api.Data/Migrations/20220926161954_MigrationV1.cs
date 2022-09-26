using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bulletins",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    STDGUID = table.Column<string>(nullable: false),
                    CURGUID = table.Column<string>(nullable: false),
                    SBJGUID = table.Column<string>(nullable: false),
                    BLTPERIOD = table.Column<string>(nullable: false),
                    BLTEVALACTIVITY1 = table.Column<string>(nullable: true, defaultValue: "0"),
                    BLTEVALACTIVITY2 = table.Column<string>(nullable: true, defaultValue: "0"),
                    BLTEVALACTIVITY3 = table.Column<string>(nullable: true, defaultValue: "0"),
                    BLTEVALACTIVITYEND = table.Column<string>(nullable: true, defaultValue: "0"),
                    BLTSTATUS = table.Column<int>(nullable: false, defaultValue: 0),
                    BLTCOUNTRRP = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bulletins", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    CURNAME = table.Column<string>(maxLength: 255, nullable: false),
                    CURTYPE = table.Column<int>(nullable: false),
                    CURSUBTYPE = table.Column<int>(nullable: false),
                    CURMODALITY = table.Column<int>(nullable: false),
                    CURWORKLOAD = table.Column<int>(nullable: false),
                    CUROFFERABLE = table.Column<int>(nullable: false),
                    CUROFFERABLESYNCE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    STDFULLNAME = table.Column<string>(maxLength: 255, nullable: false),
                    STDSOCIALNAME = table.Column<string>(maxLength: 255, nullable: false),
                    STDREGISTRATION = table.Column<string>(maxLength: 32, nullable: false),
                    STDDOCTYPE = table.Column<string>(maxLength: 32, nullable: true),
                    STDDOCID = table.Column<string>(maxLength: 32, nullable: true),
                    STDEMAIL = table.Column<string>(maxLength: 100, nullable: false),
                    STDPHONE = table.Column<string>(maxLength: 32, nullable: true),
                    STDBIRTHDATE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    SBJNAME = table.Column<string>(maxLength: 255, nullable: false),
                    SBJTYPE = table.Column<string>(nullable: false),
                    SBJSUBTYPE = table.Column<string>(nullable: true),
                    SBJMODALITY = table.Column<string>(nullable: false),
                    SBJWORKLOAD = table.Column<string>(nullable: false),
                    SBJOFFERABLE = table.Column<string>(nullable: false),
                    SBJOFFERABLESYNCE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    USERNAME = table.Column<string>(maxLength: 100, nullable: false),
                    USEREMAIL = table.Column<string>(nullable: true),
                    USERBIRTHDATE = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.GUID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_STDEMAIL",
                table: "students",
                column: "STDEMAIL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_STDREGISTRATION",
                table: "students",
                column: "STDREGISTRATION",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_USEREMAIL",
                table: "user",
                column: "USEREMAIL",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bulletins");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
