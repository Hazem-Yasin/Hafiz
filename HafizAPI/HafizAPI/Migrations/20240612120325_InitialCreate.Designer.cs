﻿// <auto-generated />
using System;
using HafizApi.Data;
using HafizApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HafizApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240612120325_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HafizApi.Models.Ayah", b =>
                {
                    b.Property<int>("AyahID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AyahID"));

                    b.Property<int>("AyahNumber")
                        .HasColumnType("int");

                    b.Property<string>("AyahText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SurahID")
                        .HasColumnType("int");

                    b.Property<int>("SurahNumberID")
                        .HasColumnType("int");

                    b.HasKey("AyahID");

                    b.HasIndex("SurahID");

                    b.ToTable("Ayat");
                });

            modelBuilder.Entity("HafizApi.Models.Surah", b =>
                {
                    b.Property<int>("SurahID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SurahID"));

                    b.Property<int>("NumberOfAyat")
                        .HasColumnType("int");

                    b.Property<string>("SurahName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurahID");

                    b.ToTable("Surahs");
                });

            modelBuilder.Entity("HafizApi.Models.Ayah", b =>
                {
                    b.HasOne("HafizApi.Models.Surah", "surah")
                        .WithMany("Ayahs")
                        .HasForeignKey("SurahID");

                    b.Navigation("surah");
                });

            modelBuilder.Entity("HafizApi.Models.Surah", b =>
                {
                    b.Navigation("Ayahs");
                });
#pragma warning restore 612, 618
        }
    }
}
