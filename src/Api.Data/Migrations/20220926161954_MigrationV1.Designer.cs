﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220926161954_MigrationV1")]
    partial class MigrationV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.BillEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("BLTCOUNTRRP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("BLTEVALACTIVITY1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasDefaultValue("0");

                    b.Property<string>("BLTEVALACTIVITY2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasDefaultValue("0");

                    b.Property<string>("BLTEVALACTIVITY3")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasDefaultValue("0");

                    b.Property<string>("BLTEVALACTIVITYEND")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasDefaultValue("0");

                    b.Property<string>("BLTPERIOD")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("BLTSTATUS")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CURGUID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SBJGUID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("STDGUID")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.ToTable("bulletins");
                });

            modelBuilder.Entity("Api.Domain.Entities.CourseEntity", b =>
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
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

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
                });

            modelBuilder.Entity("Api.Domain.Entities.StudentEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("STDBIRTHDATE")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("STDDOCID")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<string>("STDDOCTYPE")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<string>("STDEMAIL")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("STDFULLNAME")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("STDPHONE")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<string>("STDREGISTRATION")
                        .IsRequired()
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<string>("STDSOCIALNAME")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.HasIndex("STDEMAIL")
                        .IsUnique();

                    b.HasIndex("STDREGISTRATION")
                        .IsUnique();

                    b.ToTable("students");
                });

            modelBuilder.Entity("Api.Domain.Entities.SubjectEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SBJMODALITY")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SBJNAME")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("SBJOFFERABLE")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("SBJOFFERABLESYNCE")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SBJSUBTYPE")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SBJTYPE")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SBJWORKLOAD")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GUID");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("USERBIRTHDATE")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("USEREMAIL")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("USERNAME")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("GUID");

                    b.HasIndex("USEREMAIL")
                        .IsUnique();

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}