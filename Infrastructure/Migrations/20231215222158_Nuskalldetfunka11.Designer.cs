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
    [Migration("20231215222158_Nuskalldetfunka11")]
    partial class Nuskalldetfunka11
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
                            Id = new Guid("9a03f3eb-266a-4b05-bdd5-1b8157f23908"),
                            CanFly = true,
                            Name = "tweetie"
                        },
                        new
                        {
                            Id = new Guid("e64ef920-e1f7-4ac0-8124-e759514e3f67"),
                            CanFly = false,
                            Name = "chickennugget"
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
                            Id = new Guid("7955d2f6-3e3e-4cbb-8b77-bbfc6db9e8ea"),
                            LikesToPlay = true,
                            Name = "Pandis"
                        },
                        new
                        {
                            Id = new Guid("c3bf6e4c-e135-4c57-a928-d26c33733076"),
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
                            Id = new Guid("d8705753-dcb7-48e0-83d5-322855d93134"),
                            Name = "Björn"
                        },
                        new
                        {
                            Id = new Guid("ae2db5f4-90a2-4caf-8589-f13e6ed42fa1"),
                            Name = "Patrik"
                        },
                        new
                        {
                            Id = new Guid("88487084-f445-4904-9d21-e0df905fdb21"),
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
                            Id = new Guid("99760a78-dc4a-4738-ba51-057a46ae362b"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
