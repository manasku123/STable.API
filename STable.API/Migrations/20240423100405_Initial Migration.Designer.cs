﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STable.API.Data;

#nullable disable

namespace STable.API.Migrations
{
    [DbContext(typeof(STableDbContext))]
    [Migration("20240423100405_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("STable.API.Model.Domain.Result", b =>
                {
                    b.Property<int>("MarkSheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkSheetId"));

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Totalmark")
                        .HasColumnType("int");

                    b.HasKey("MarkSheetId");

                    b.HasIndex("StudentId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("STable.API.Model.Domain.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentClass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("STable.API.Model.Domain.Result", b =>
                {
                    b.HasOne("STable.API.Model.Domain.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
