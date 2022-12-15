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
    [Migration("20221215112504_added-Dtog")]
    partial class addedDtog
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
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("3908e7bc-06a9-4351-a696-99dfbb46b896"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("1b61bfd6-786d-4830-ad17-f909c0ebfc80"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("ad04993d-df4f-4c21-ab90-2e1610bb969b"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("d331b226-47e8-4017-a735-9e300119a1da"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("02291c0e-5c88-4ab7-a7dc-e0127dbbad11"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        },
                        new
                        {
                            Id = new Guid("1484d604-f82d-4487-a418-d64e10659a7a"),
                            Brand = "John",
                            Color = "Somewhere",
                            FullDescription = "",
                            Model = "Iron Man",
                            Price = 2.02,
                            SmartDescription = "",
                            State = "",
                            Year = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
