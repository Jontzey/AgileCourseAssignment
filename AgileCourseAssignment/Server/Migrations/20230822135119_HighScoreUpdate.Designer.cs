﻿// <auto-generated />
using AgileCourseAssignment.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgileCourseAssignment.Server.Migrations
{
    [DbContext(typeof(FlagScapeDb))]
    [Migration("20230822135119_HighScoreUpdate")]
    partial class HighScoreUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgileCourseAssignment.Shared.Models.FlagsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Flags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "Germany",
                            Image = "Germany.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "Austria",
                            Image = "Austria.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "Spain",
                            Image = "Bandera_de_España.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 4,
                            CountryName = "Belgium",
                            Image = "Flag_of_Belgium_(civil).jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 5,
                            CountryName = "Bulgaria",
                            Image = "Flag_of_Bulgaria.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 6,
                            CountryName = "Croatia",
                            Image = "Flag_of_Croatia.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 7,
                            CountryName = "Denmark",
                            Image = "Flag_of_Denmark.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 8,
                            CountryName = "Estonia",
                            Image = "Flag_of_Estonia.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 9,
                            CountryName = "Finland",
                            Image = "Flag_of_Finland_(bordered).jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 10,
                            CountryName = "Iceland",
                            Image = "Flag_of_Iceland.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 11,
                            CountryName = "Italy",
                            Image = "Flag_of_Italy.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 12,
                            CountryName = "Lithuania",
                            Image = "Flag_of_Lithuania.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 13,
                            CountryName = "Poland",
                            Image = "Flag_of_Poland.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 14,
                            CountryName = "Slovakia",
                            Image = "Flag_of_Slovakia.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 15,
                            CountryName = "Slovenia",
                            Image = "Flag_of_Slovenia.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 16,
                            CountryName = "Sweden",
                            Image = "Flag_of_Sweden.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 17,
                            CountryName = "Turkey",
                            Image = "Flag_of_Turkey.svg.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 18,
                            CountryName = "Albania",
                            Image = "Flag-Albania.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 19,
                            CountryName = "Czech Republic",
                            Image = "flag-czech-vector-illustration_514344-268.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 20,
                            CountryName = "Hungary",
                            Image = "Flag-Hungary.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 21,
                            CountryName = "Ireland",
                            Image = "FLAG-Ireland.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 22,
                            CountryName = "Latvia",
                            Image = "Flag-Latvia.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 23,
                            CountryName = "Norway",
                            Image = "Flag-Norway.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 24,
                            CountryName = "Ukraine",
                            Image = "Flag-Ukraine.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 25,
                            CountryName = "France",
                            Image = "france-151928_640.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 26,
                            CountryName = "Greece",
                            Image = "greece.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 27,
                            CountryName = "Portugal",
                            Image = "portugals-flagga.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 28,
                            CountryName = "Netherlands",
                            Image = "iStock-471776245.jpg",
                            IsUsed = false
                        },
                        new
                        {
                            Id = 29,
                            CountryName = "Switzerland",
                            Image = "Switzerland-Flag.jpg",
                            IsUsed = false
                        });
                });

            modelBuilder.Entity("AgileCourseAssignment.Shared.Models.HighScoreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HighScore");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test",
                            Score = 150,
                            Time = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}