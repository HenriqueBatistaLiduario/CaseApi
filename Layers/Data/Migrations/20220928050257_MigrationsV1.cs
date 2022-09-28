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
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    CURNAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CURTYPE = table.Column<int>(type: "int", nullable: false),
                    CURSUBTYPE = table.Column<int>(type: "int", nullable: false),
                    CURMODALITY = table.Column<int>(type: "int", nullable: false),
                    CURWORKLOAD = table.Column<int>(type: "int", nullable: false),
                    CUROFFERABLE = table.Column<int>(type: "int", nullable: false),
                    CUROFFERABLESYNCE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    PFLALIAS = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    PFLTITLE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PFLASSIGNMENTS = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    STDFULLNAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    STDSOCIALNAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    STDREGISTRATION = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    STDDOCTYPE = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    STDDOCID = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    STDEMAIL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    STDPHONE = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true),
                    STDBIRTHDATE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    SBJNAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    SBJTYPE = table.Column<string>(type: "longtext", nullable: false),
                    SBJSUBTYPE = table.Column<string>(type: "longtext", nullable: true),
                    SBJMODALITY = table.Column<string>(type: "longtext", nullable: false),
                    SBJWORKLOAD = table.Column<string>(type: "longtext", nullable: false),
                    SBJOFFERABLE = table.Column<string>(type: "longtext", nullable: false),
                    SBJOFFERABLESYNCE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CourseEntityGUID = table.Column<Guid>(type: "char(36)", nullable: true),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_subjects_courses_CourseEntityGUID",
                        column: x => x.CourseEntityGUID,
                        principalTable: "courses",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    USERNAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    USEREMAIL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ProfileGUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    GUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    STDGUID = table.Column<string>(type: "longtext", nullable: false),
                    STDREGISTRATION = table.Column<string>(type: "longtext", nullable: false),
                    STDFULLNAME = table.Column<string>(type: "longtext", nullable: false),
                    CURGUID = table.Column<string>(type: "longtext", nullable: false),
                    CURNAME = table.Column<string>(type: "longtext", nullable: false),
                    SBJGUID = table.Column<string>(type: "longtext", nullable: false),
                    SBJNAME = table.Column<string>(type: "longtext", nullable: false),
                    BLTPERIOD = table.Column<string>(type: "longtext", nullable: false),
                    BLTTYPE = table.Column<int>(type: "int", nullable: false),
                    BLTEVALACTIVITY1 = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITY2 = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITY3 = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    BLTEVALACTIVITYEND = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    BLTSTATUS = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BLTDELIVERYDATE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CourseGUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    SubjectGUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    StudentGUID = table.Column<Guid>(type: "char(36)", nullable: false),
                    CREATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UPDATEDON = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    { new Guid("f6ed78e4-e6bc-476b-bbf7-699cc0c86456"), new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(252), 1, "MBA Executivo em Segurança Cibernética", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 400, null },
                    { new Guid("994f7446-4541-4ba0-8021-1a6d369c611d"), new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1727), 1, "Analista de Comportamento e de Carreiras", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 60, null },
                    { new Guid("0780ac95-4bf4-4d35-b4f3-0152b0d7d32a"), new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1735), 1, "Analista em Inteligência Emocional", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 60, null },
                    { new Guid("32b573d5-ce0b-48ae-bc2b-8fff78743a62"), new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1740), 1, "Auditoria Pública", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 20, null },
                    { new Guid("ef069aa1-0ce9-4041-8c9a-3e866ed78f51"), new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1745), 1, "Educação Bilíngue", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 120, null }
                });

            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "GUID", "CREATEDON", "PFLALIAS", "PFLASSIGNMENTS", "PFLTITLE", "UPDATEDON" },
                values: new object[,]
                {
                    { new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb"), new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7003), "ADM", "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;PostNotes;ConsultBulletin", "Administrador do sistema", null },
                    { new Guid("d159d7e8-69cb-48b4-9f00-43d3aa290717"), new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7018), "SAA", "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;", "Secretaria Acadêmica", null },
                    { new Guid("8bde56dc-1f68-4b88-9a74-39551ed13bf3"), new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7024), "TUT", "ConsultCourseList;ConsultCurriculumByCourse;ConsultListStudentsByCourse;PostNotes;", "Tutor", null },
                    { new Guid("4f974a4c-6a91-44f5-ad56-9ab3b2f18903"), new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7029), "STD", "ConsultCourseList;ConsultCurriculumByCourse;RegisterStudent;ConsultBulletin;", "Estudante/Aluno", null }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "GUID", "CREATEDON", "ProfileGUID", "UPDATEDON", "USEREMAIL", "USERNAME" },
                values: new object[] { new Guid("d6cfa752-1c3e-4c86-8050-b1731e439f83"), new DateTime(2022, 9, 27, 22, 2, 57, 148, DateTimeKind.Local).AddTicks(8111), new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb"), new DateTime(2022, 9, 27, 22, 2, 57, 151, DateTimeKind.Local).AddTicks(4094), "ntt.hbatistl@gmail.com", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_bulletins_CourseGUID",
                table: "bulletins",
                column: "CourseGUID");

            migrationBuilder.CreateIndex(
                name: "IX_bulletins_StudentGUID",
                table: "bulletins",
                column: "StudentGUID");

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
                name: "IX_subjects_CourseEntityGUID",
                table: "subjects",
                column: "CourseEntityGUID");

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
