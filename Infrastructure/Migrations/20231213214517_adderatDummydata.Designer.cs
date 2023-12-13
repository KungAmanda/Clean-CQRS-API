﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(RealDatabase))]
    [Migration("20231213214517_adderatDummydata")]
    partial class adderatDummydata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Birds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60a7829b-ba8a-42d3-8690-493abb35a77f"),
                            CanFly = true,
                            Name = "TwitterGod"
                        },
                        new
                        {
                            Id = new Guid("462a712f-1588-4320-b56a-64fcb480454a"),
                            CanFly = false,
                            Name = "TobiasNugget"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("161deaf0-cb2b-498c-bfa4-a635e2ec1427"),
                            LikesToPlay = true,
                            Name = "Garfield"
                        },
                        new
                        {
                            Id = new Guid("905c0d35-2e4d-4d80-b2c6-aa73249aae77"),
                            LikesToPlay = false,
                            Name = "HorseCatDude"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345675"),
                            LikesToPlay = true,
                            Name = "AmandatheUglyCat"
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345671"),
                            Name = "TestDogForUnitTests1"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345672"),
                            Name = "TestDogForUnitTests2"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345673"),
                            Name = "TestDogForUnitTests3"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345674"),
                            Name = "TestDogForUnitTests4"
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
                            Id = new Guid("3074923a-6aeb-45ad-9f06-72ba1455e9fd"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}