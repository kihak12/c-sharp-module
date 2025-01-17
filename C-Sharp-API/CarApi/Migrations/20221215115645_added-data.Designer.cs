﻿// <auto-generated />
using System;
using CarApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221215115645_added-data")]
    partial class addeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarApi.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("SmartDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d581da4c-aa05-454c-b2f7-7be925c158d1"),
                            Brand = "Audi",
                            Color = "Black",
                            FullDescription = "A full description with many informations",
                            Model = "AU-167",
                            Price = 12000.0,
                            SmartDescription = "A smart description",
                            State = "New",
                            Year = 2017
                        },
                        new
                        {
                            Id = new Guid("180e526a-1b7c-4bfe-8649-6410798be28c"),
                            Brand = "Ford",
                            Color = "Orange",
                            FullDescription = "A full description with many informations",
                            Model = "FD-777",
                            Price = 125900.0,
                            SmartDescription = "A smart description",
                            State = "Good condition",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("b1b5fd5b-dfe9-463b-b490-726c476403ab"),
                            Brand = "Ford",
                            Color = "Red",
                            FullDescription = "A full description with many informations",
                            Model = "FD-689",
                            Price = 1100.0,
                            SmartDescription = "A smart description",
                            State = "Wreck",
                            Year = 2012
                        },
                        new
                        {
                            Id = new Guid("2329a453-70ac-4252-8f62-f19168479720"),
                            Brand = "BMW",
                            Color = "Blue",
                            FullDescription = "A full description with many informations",
                            Model = "BM-045",
                            Price = 15000.0,
                            SmartDescription = "A smart description",
                            State = "New",
                            Year = 2017
                        },
                        new
                        {
                            Id = new Guid("df171aef-c21d-4231-ab58-202f9f4d929d"),
                            Brand = "Opel",
                            Color = "Black",
                            FullDescription = "A full description with many informations",
                            Model = "OP-001",
                            Price = 4000.0,
                            SmartDescription = "A smart description",
                            State = "Good condition",
                            Year = 2010
                        },
                        new
                        {
                            Id = new Guid("a5ea99b2-bb0a-470e-b5ef-8ef12a512bdc"),
                            Brand = "Dacia",
                            Color = "White",
                            FullDescription = "A full description with many informations",
                            Model = "DC-258",
                            Price = 6500.0,
                            SmartDescription = "A smart description",
                            State = "Good condition",
                            Year = 2011
                        },
                        new
                        {
                            Id = new Guid("457033c8-facd-4c77-b444-466a7b0c4d2e"),
                            Brand = "Land Rover",
                            Color = "Brown",
                            FullDescription = "A full description with many informations",
                            Model = "LR-777",
                            Price = 8420.0,
                            SmartDescription = "A smart description",
                            State = "Good condition",
                            Year = 2015
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
