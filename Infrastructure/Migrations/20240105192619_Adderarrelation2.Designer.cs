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
    [Migration("20240105192619_Adderarrelation2")]
    partial class Adderarrelation2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnimalModel");

                    b.UseTphMappingStrategy();
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
                            Id = new Guid("a77c05d0-00b4-4580-88f7-f6d425ebebe4"),
                            PasswordHash = "string",
                            Username = "Pandis"
                        });
                });

            modelBuilder.Entity("Domain.Models.UserAnimalModel", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Key");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnimals");

                    b.HasData(
                        new
                        {
                            Key = new Guid("a7911894-6cea-4848-8cd5-bd74e83b569f"),
                            AnimalId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<bool>("CanFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Bird");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ff40194e-6f08-4a89-b25a-19263eaa8e53"),
                            Name = "tweetie",
                            CanFly = true,
                            Color = "green"
                        },
                        new
                        {
                            Id = new Guid("59a32514-a8d5-4ce5-bcf7-1dbd9c1f6977"),
                            Name = "chickennugget",
                            CanFly = false,
                            Color = "purple"
                        },
                        new
                        {
                            Id = new Guid("d57be61a-4492-4a65-bba1-81a4be581f73"),
                            Name = "fågeljävel",
                            CanFly = true,
                            Color = "yellow"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cat");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a06b9023-d241-4a3b-bac3-f60de27f920e"),
                            Name = "Pandis",
                            Breed = "skogskatt",
                            LikesToPlay = true,
                            Weight = 5
                        },
                        new
                        {
                            Id = new Guid("604c0308-f0f3-4cf6-8720-2086adc8d508"),
                            Name = "MjauMjau",
                            Breed = "Mainecoon",
                            LikesToPlay = false,
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345675"),
                            Name = "Gustaf",
                            Breed = "bengal",
                            LikesToPlay = true,
                            Weight = 5
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("Breed")
                                .HasColumnName("Dog_Breed");

                            t.Property("Weight")
                                .HasColumnName("Dog_Weight");
                        });

                    b.HasDiscriminator().HasValue("Dog");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb949627-8668-4422-a769-e68337d76648"),
                            Name = "Björn",
                            Breed = "shitzu",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("ed0ed9d7-1c1c-4acc-9ed9-23ddf233f5d3"),
                            Name = "Patrik",
                            Breed = "labrador",
                            Weight = 35
                        },
                        new
                        {
                            Id = new Guid("59d1cb97-0800-47b2-82fd-7ae2a41e5f3d"),
                            Name = "Alfred",
                            Breed = "golden",
                            Weight = 35
                        },
                        new
                        {
                            Id = new Guid("12345678-1234-5678-1234-567812345678"),
                            Name = "TestDogForUnitTests",
                            Breed = "bulldog",
                            Weight = 20
                        },
                        new
                        {
                            Id = new Guid("87654321-4321-8765-4321-876543210987"),
                            Name = "AnotherTestDogForUnitTests",
                            Breed = "pitbull",
                            Weight = 30
                        });
                });

            modelBuilder.Entity("Domain.Models.UserAnimalModel", b =>
                {
                    b.HasOne("Domain.Models.Animal.AnimalModel", "Animal")
                        .WithMany("UserAnimal")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserAnimal")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Navigation("UserAnimal");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("UserAnimal");
                });
#pragma warning restore 612, 618
        }
    }
}