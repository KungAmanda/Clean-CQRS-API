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
    [Migration("20231219210519_sparauser2")]
    partial class sparauser2
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
                            Id = new Guid("46fc28e4-0f5d-4c7e-85ba-2d6476ec5e2e"),
                            CanFly = true,
                            Name = "tweetie"
                        },
                        new
                        {
                            Id = new Guid("8726fb15-e710-416d-87b4-0dfadeb2af09"),
                            CanFly = false,
                            Name = "chickennugget"
                        },
                        new
                        {
                            Id = new Guid("169a4fa3-a4dd-44b9-a15b-1f7230ee6277"),
                            CanFly = true,
                            Name = "fågeljävel"
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
                            Id = new Guid("bcc042c7-2399-4c64-a7cf-85bac01cc557"),
                            LikesToPlay = true,
                            Name = "Pandis"
                        },
                        new
                        {
                            Id = new Guid("d579125b-f251-45be-b2c8-c9a56dcc8d2a"),
                            LikesToPlay = false,
                            Name = "MjauMjau"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345675"),
                            LikesToPlay = true,
                            Name = "Gustaf"
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
                            Id = new Guid("f5d8e4fd-ffe9-4f0b-afa6-e5ee7845a584"),
                            Name = "Björn"
                        },
                        new
                        {
                            Id = new Guid("c01522c1-431f-4f57-a0d4-8be74cda7424"),
                            Name = "Patrik"
                        },
                        new
                        {
                            Id = new Guid("6dc2032c-b0b1-4559-bd68-b514c64d6f35"),
                            Name = "Alfred"
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345678"),
                            Name = "TestDogForUnitTests"
                        },
                        new
                        {
                            Id = new Guid("87654321-4321-8765-4321-876543210987"),
                            Name = "AnotherTestDogForUnitTests"
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
                            Id = new Guid("29e0eb66-8a07-4768-b181-528ee48367d6"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
