﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Domain.Entities.BillEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("BLTDELIVERYDATE")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("BLTEVALACTIVITY1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<float>("BLTEVALACTIVITY2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<float>("BLTEVALACTIVITY3")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<float>("BLTEVALACTIVITYEND")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0f);

                    b.Property<string>("BLTPERIOD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("BLTSTATUS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("BLTTYPE")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CURGUID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CURNAME")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("CourseGUID")
                        .HasColumnType("char(36)");

                    b.Property<string>("SBJGUID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SBJNAME")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("STDFULLNAME")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("STDGUID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("STDREGISTRATION")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("StudentGUID")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SubjectGUID")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.HasIndex("CourseGUID");

                    b.HasIndex("StudentGUID");

                    b.HasIndex("SubjectGUID");

                    b.ToTable("bulletins");
                });

            modelBuilder.Entity("Domain.Entities.CourseEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CURMODALITY")
                        .HasColumnType("int");

                    b.Property<string>("CURNAME")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("CUROFFERABLE")
                        .HasColumnType("int");

                    b.Property<DateTime>("CUROFFERABLESYNCE")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CURSUBTYPE")
                        .HasColumnType("int");

                    b.Property<int>("CURTYPE")
                        .HasColumnType("int");

                    b.Property<int>("CURWORKLOAD")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            GUID = new Guid("f6ed78e4-e6bc-476b-bbf7-699cc0c86456"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(252),
                            CURMODALITY = 1,
                            CURNAME = "MBA Executivo em Segurança Cibernética",
                            CUROFFERABLE = 0,
                            CUROFFERABLESYNCE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CURSUBTYPE = 0,
                            CURTYPE = 2,
                            CURWORKLOAD = 400
                        },
                        new
                        {
                            GUID = new Guid("994f7446-4541-4ba0-8021-1a6d369c611d"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1727),
                            CURMODALITY = 1,
                            CURNAME = "Analista de Comportamento e de Carreiras",
                            CUROFFERABLE = 0,
                            CUROFFERABLESYNCE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CURSUBTYPE = 0,
                            CURTYPE = 3,
                            CURWORKLOAD = 60
                        },
                        new
                        {
                            GUID = new Guid("0780ac95-4bf4-4d35-b4f3-0152b0d7d32a"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1735),
                            CURMODALITY = 1,
                            CURNAME = "Analista em Inteligência Emocional",
                            CUROFFERABLE = 0,
                            CUROFFERABLESYNCE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CURSUBTYPE = 0,
                            CURTYPE = 3,
                            CURWORKLOAD = 60
                        },
                        new
                        {
                            GUID = new Guid("32b573d5-ce0b-48ae-bc2b-8fff78743a62"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1740),
                            CURMODALITY = 1,
                            CURNAME = "Auditoria Pública",
                            CUROFFERABLE = 0,
                            CUROFFERABLESYNCE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CURSUBTYPE = 0,
                            CURTYPE = 3,
                            CURWORKLOAD = 20
                        },
                        new
                        {
                            GUID = new Guid("ef069aa1-0ce9-4041-8c9a-3e866ed78f51"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 147, DateTimeKind.Utc).AddTicks(1745),
                            CURMODALITY = 1,
                            CURNAME = "Educação Bilíngue",
                            CUROFFERABLE = 0,
                            CUROFFERABLESYNCE = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CURSUBTYPE = 0,
                            CURTYPE = 3,
                            CURWORKLOAD = 120
                        });
                });

            modelBuilder.Entity("Domain.Entities.ProfileEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PFLALIAS")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PFLASSIGNMENTS")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PFLTITLE")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.HasIndex("PFLALIAS")
                        .IsUnique();

                    b.ToTable("profiles");

                    b.HasData(
                        new
                        {
                            GUID = new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7003),
                            PFLALIAS = "ADM",
                            PFLASSIGNMENTS = "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;PostNotes;ConsultBulletin",
                            PFLTITLE = "Administrador do sistema"
                        },
                        new
                        {
                            GUID = new Guid("d159d7e8-69cb-48b4-9f00-43d3aa290717"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7018),
                            PFLALIAS = "SAA",
                            PFLASSIGNMENTS = "RegisterCourse;ConsultCourseList;RegisterSubject;ManageCurriculum;ConsultCurriculumByCourse;RegisterStudent;ConsultListStudentsByCourse;",
                            PFLTITLE = "Secretaria Acadêmica"
                        },
                        new
                        {
                            GUID = new Guid("8bde56dc-1f68-4b88-9a74-39551ed13bf3"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7024),
                            PFLALIAS = "TUT",
                            PFLASSIGNMENTS = "ConsultCourseList;ConsultCurriculumByCourse;ConsultListStudentsByCourse;PostNotes;",
                            PFLTITLE = "Tutor"
                        },
                        new
                        {
                            GUID = new Guid("4f974a4c-6a91-44f5-ad56-9ab3b2f18903"),
                            CREATEDON = new DateTime(2022, 9, 28, 5, 2, 57, 148, DateTimeKind.Utc).AddTicks(7029),
                            PFLALIAS = "STD",
                            PFLASSIGNMENTS = "ConsultCourseList;ConsultCurriculumByCourse;RegisterStudent;ConsultBulletin;",
                            PFLTITLE = "Estudante/Aluno"
                        });
                });

            modelBuilder.Entity("Domain.Entities.StudentEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("STDBIRTHDATE")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("STDDOCID")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("STDDOCTYPE")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("STDEMAIL")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("STDFULLNAME")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("STDPHONE")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("STDREGISTRATION")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("STDSOCIALNAME")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.HasIndex("STDEMAIL")
                        .IsUnique();

                    b.HasIndex("STDREGISTRATION")
                        .IsUnique();

                    b.ToTable("students");
                });

            modelBuilder.Entity("Domain.Entities.SubjectEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CourseEntityGUID")
                        .HasColumnType("char(36)");

                    b.Property<string>("SBJMODALITY")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SBJNAME")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SBJOFFERABLE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SBJOFFERABLESYNCE")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SBJSUBTYPE")
                        .HasColumnType("longtext");

                    b.Property<string>("SBJTYPE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SBJWORKLOAD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.HasIndex("CourseEntityGUID");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("ProfileGUID")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("USEREMAIL")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("GUID");

                    b.HasIndex("ProfileGUID");

                    b.HasIndex("USEREMAIL")
                        .IsUnique();

                    b.ToTable("user");

                    b.HasData(
                        new
                        {
                            GUID = new Guid("d6cfa752-1c3e-4c86-8050-b1731e439f83"),
                            CREATEDON = new DateTime(2022, 9, 27, 22, 2, 57, 148, DateTimeKind.Local).AddTicks(8111),
                            ProfileGUID = new Guid("0bd34160-38f5-4bac-9378-4adc936ce6eb"),
                            UPDATEDON = new DateTime(2022, 9, 27, 22, 2, 57, 151, DateTimeKind.Local).AddTicks(4094),
                            USEREMAIL = "ntt.hbatistl@gmail.com",
                            USERNAME = "Administrador"
                        });
                });

            modelBuilder.Entity("Domain.Entities.BillEntity", b =>
                {
                    b.HasOne("Domain.Entities.CourseEntity", "Course")
                        .WithMany()
                        .HasForeignKey("CourseGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.StudentEntity", "Student")
                        .WithMany("Bills")
                        .HasForeignKey("StudentGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.SubjectEntity", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Domain.Entities.SubjectEntity", b =>
                {
                    b.HasOne("Domain.Entities.CourseEntity", null)
                        .WithMany("Subjects")
                        .HasForeignKey("CourseEntityGUID");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.HasOne("Domain.Entities.ProfileEntity", "Profile")
                        .WithMany("Users")
                        .HasForeignKey("ProfileGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Domain.Entities.CourseEntity", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Domain.Entities.ProfileEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.StudentEntity", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}