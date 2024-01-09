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
    [Migration("20240105192940_Adderarrelation3")]
    partial class Adderarrelation3
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
                            Id = new Guid("854a1d87-43f5-438a-8f7f-1940485d3ba8"),
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
                            Key = new Guid("3ad1e2a9-976b-495f-a5e8-84f5d7960298"),
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
                            Id = new Guid("4f80b646-35d6-4d90-8ac8-a701bb4b35b5"),
                            Name = "tweetie",
                            CanFly = true,
                            Color = "green"
                        },
                        new
                        {
                            Id = new Guid("55fc0902-dd9c-4fec-bdff-655ae055a587"),
                            Name = "chickennugget",
                            CanFly = false,
                            Color = "purple"
                        },
                        new
                        {
                            Id = new Guid("b4b3c8e2-6d7d-471b-b013-5bed30df1c10"),
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
                            Id = new Guid("1a264460-7735-4973-8915-0f4143541aba"),
                            Name = "Pandis",
                            Breed = "skogskatt",
                            LikesToPlay = true,
                            Weight = 5
                        },
                        new
                        {
                            Id = new Guid("bfff674e-d194-4594-b85f-b319e8e8d7f4"),
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
                            Id = new Guid("97fd2ad8-e688-4fb6-85a5-9d7c321cf92b"),
                            Name = "Björn",
                            Breed = "shitzu",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("242dea6b-bbc3-4f48-8019-6a70f907e84b"),
                            Name = "Patrik",
                            Breed = "labrador",
                            Weight = 35
                        },
                        new
                        {
                            Id = new Guid("f6825346-1cbe-471b-934b-f8eef435f26c"),
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