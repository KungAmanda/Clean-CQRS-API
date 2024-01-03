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
    [Migration("20231219202814_sparauser")]
    partial class sparauser
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
                            Id = new Guid("bb44532a-fbce-42f5-a3d8-37dc9429b44d"),
                            CanFly = true,
                            Name = "tweetie"
                        },
                        new
                        {
                            Id = new Guid("20a70e4e-a49b-4f22-b92a-4490dffb6698"),
                            CanFly = false,
                            Name = "chickennugget"
                        },
                        new
                        {
                            Id = new Guid("19b1da8d-3fb0-445b-9685-843a858cefa8"),
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
                            Id = new Guid("2a36d00d-d4df-401e-932f-afb6de35f23e"),
                            LikesToPlay = true,
                            Name = "Pandis"
                        },
                        new
                        {
                            Id = new Guid("1ea2d651-6633-4e70-a3e0-7539981bbae3"),
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
                            Id = new Guid("9f605058-55d9-4bc3-a558-664de99809a9"),
                            Name = "Björn"
                        },
                        new
                        {
                            Id = new Guid("0fc54d36-10f2-4854-b391-0f22a3920ffe"),
                            Name = "Patrik"
                        },
                        new
                        {
                            Id = new Guid("4fd24afe-3f61-4034-a925-80cd74fff7ee"),
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
                            Id = new Guid("7454ab83-401f-45b2-b7e4-dd27193b2958"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}