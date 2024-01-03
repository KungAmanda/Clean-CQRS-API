﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(RealDatabase))]
    partial class RealDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("CanFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Birds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f53de2d-b89c-4db8-9043-faea28be5d6c"),
                            CanFly = true,
                            Color = "green",
                            Name = "tweetie"
                        },
                        new
                        {
                            Id = new Guid("5255b546-1a8d-41cd-9cd6-6fb352c7b60c"),
                            CanFly = false,
                            Color = "purple",
                            Name = "chickennugget"
                        },
                        new
                        {
                            Id = new Guid("d819c89f-3451-4377-bfeb-a7b11ce9ec78"),
                            CanFly = true,
                            Color = "yellow",
                            Name = "fågeljävel"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d084a2cf-fd65-4448-a4ae-295bb13f3ce2"),
                            Breed = "skogskatt",
                            LikesToPlay = true,
                            Name = "Pandis",
                            Weight = 5
                        },
                        new
                        {
                            Id = new Guid("bb6abe46-746e-45a7-99ba-9b8d29865ac1"),
                            Breed = "Mainecoon",
                            LikesToPlay = false,
                            Name = "MjauMjau",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345675"),
                            Breed = "bengal",
                            LikesToPlay = true,
                            Name = "Gustaf",
                            Weight = 5
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e3ce154-c54b-41e4-bde6-5a41fb62492c"),
                            Breed = "shitzu",
                            Name = "Björn",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("ec7e2984-e160-49e3-98b6-f294cfe219b7"),
                            Breed = "labrador",
                            Name = "Patrik",
                            Weight = 35
                        },
                        new
                        {
                            Id = new Guid("027c5aed-ba2c-4b4a-9a00-cc03e805f802"),
                            Breed = "golden",
                            Name = "Alfred",
                            Weight = 35
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345678"),
                            Breed = "bulldog",
                            Name = "TestDogForUnitTests",
                            Weight = 20
                        },
                        new
                        {
                            Id = new Guid("87654321-4321-8765-4321-876543210987"),
                            Breed = "pitbull",
                            Name = "AnotherTestDogForUnitTests",
                            Weight = 30
                        });
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ea493d9-2756-436d-8de0-cd70a4afec5b"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
