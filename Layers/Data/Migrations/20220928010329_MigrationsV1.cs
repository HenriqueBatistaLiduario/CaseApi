using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MigrationsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "profiles",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    PFLALIAS = table.Column<string>(maxLength: 10, nullable: false),
                    PFLTITLE = table.Column<string>(maxLength: 100, nullable: false),
                    PFLASSIGNMENTS = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.GUID);
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
                    SBJOFFERABLESYNCE = table.Column<DateTime>(nullable: false),
                    CoursesGUID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_subjects_courses_CoursesGUID",
                        column: x => x.CoursesGUID,
                        principalTable: "courses",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    USERNAME = table.Column<string>(maxLength: 100, nullable: false),
                    USEREMAIL = table.Column<string>(maxLength: 100, nullable: false),
                    ProfileGUID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_user_profiles_ProfileGUID",
                        column: x => x.ProfileGUID,
                        principalTable: "profiles",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bulletins",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    CREATEDON = table.Column<DateTime>(nullable: true),
                    UPDATEDON = table.Column<DateTime>(nullable: true),
                    STDGUID = table.Column<string>(nullable: false),
                    STDREGISTRATION = table.Column<string>(nullable: false),
                    STDFULLNAME = table.Column<string>(nullable: false),
                    CURGUID = table.Column<string>(nullable: false),
                    CURNAME = table.Column<string>(nullable: false),
                    SBJGUID = table.Column<string>(nullable: false),
                    SBJNAME = table.Column<string>(nullable: false),
                    BLTPERIOD = table.Column<string>(nullable: false),
                    BLTTYPE = table.Column<int>(nullable: false),
                    BLTEVALACTIVITY1 = table.Column<float>(nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITY2 = table.Column<float>(nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITY3 = table.Column<float>(nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITYEND = table.Column<float>(nullable: false, defaultValue: 0f),
                    BLTSTATUS = table.Column<int>(nullable: false, defaultValue: 0),
                    BLTDELIVERYDATE = table.Column<DateTime>(nullable: false),
                    CourseGUID = table.Column<Guid>(nullable: false),
                    SubjectGUID = table.Column<Guid>(nullable: false),
                    StudentGUID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bulletins", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_bulletins_courses_CourseGUID",
                        column: x => x.CourseGUID,
                        principalTable: "courses",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bulletins_students_StudentGUID",
                        column: x => x.StudentGUID,
                        principalTable: "students",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bulletins_subjects_SubjectGUID",
                        column: x => x.SubjectGUID,
                        principalTable: "subjects",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "GUID", "CREATEDON", "CURMODALITY", "CURNAME", "CUROFFERABLE", "CUROFFERABLESYNCE", "CURSUBTYPE", "CURTYPE", "CURWORKLOAD", "UPDATEDON" },
                values: new object[,]
                {
                    { new Guid("f6ed78e4-e6bc-476b-bbf7-699cc0c86456"), new DateTime(2022, 9, 28, 1, 3, 28, 606, DateTimeKind.Utc).AddTicks(6739), 1, "MBA Executivo em Segurança Cibernética", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 400, null },
                    { new Guid("994f7446-4541-4ba0-8021-1a6d369c611d"), new DateTime(2022, 9, 28, 1, 3, 28, 606, DateTimeKind.Utc).AddTicks(6906), 1, "Analista de Comportamento e de Carreiras", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 60, null },
                    { new Guid("0780ac95-4bf4-4d35-b4f3-0152b0d7d32a"), new DateTime(2022, 9, 28, 1, 3, 28, 606, DateTimeKind.Utc).AddTicks(6915), 1, "Analista em Inteligência Emocional", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 60, null },
                    { new Guid("32b573d5-ce0b-48ae-bc2b-8fff78743a62"), new DateTime(2022, 9, 28, 1, 3, 28, 606, DateTimeKind.Utc).AddTicks(6920), 1, "Auditoria Pública", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 20, null },
                    { new Guid("ef069aa1-0ce9-4041-8c9a-3e866ed78f51"), new DateTime(2022, 9, 28, 1, 3, 28, 606, DateTimeKind.Utc).AddTicks(6926), 1, "Educação Bilíngue", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 120, null }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "GUID", "CREATEDON", "ProfileGUID", "UPDATEDON", "USEREMAIL", "USERNAME" },
                values: new object[] { new Guid("f8dd8462-9fdd-4c1c-a885-ee0493e84887"), new DateTime(2022, 9, 27, 18, 3, 28, 601, DateTimeKind.Local).AddTicks(6269), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 9, 27, 18, 3, 28, 604, DateTimeKind.Local).AddTicks(7515), "ntt.hbatistl@gmail.com", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_bulletins_CourseGUID",
                table: "bulletins",
                column: "CourseGUID");

            migrationBuilder.CreateIndex(
                name: "IX_bulletins_StudentGUID",
                table: "bulletins",
                column: "StudentGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_bulletins_SubjectGUID",
                table: "bulletins",
                column: "SubjectGUID");

            migrationBuilder.CreateIndex(
                name: "IX_profiles_PFLALIAS",
                table: "profiles",
                column: "PFLALIAS",
                unique: true);

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
                name: "IX_subjects_CoursesGUID",
                table: "subjects",
                column: "CoursesGUID");

            migrationBuilder.CreateIndex(
                name: "IX_user_ProfileGUID",
                table: "user",
                column: "ProfileGUID");

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
                name: "user");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
