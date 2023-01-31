﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P04Sklep.API.Data;

#nullable disable

namespace P04Sklep.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230131092531_seedProducts")]
    partial class seedProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P05Sklep.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Color = "orange",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Title = "Practical Fresh Sausages"
                        },
                        new
                        {
                            Id = 12,
                            Color = "gold",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Title = "Handcrafted Soft Bike"
                        },
                        new
                        {
                            Id = 13,
                            Color = "orchid",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Title = "Awesome Plastic Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Color = "orange",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Title = "Sleek Rubber Gloves"
                        },
                        new
                        {
                            Id = 15,
                            Color = "blue",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Title = "Rustic Rubber Shoes"
                        },
                        new
                        {
                            Id = 16,
                            Color = "orchid",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Title = "Small Cotton Cheese"
                        },
                        new
                        {
                            Id = 17,
                            Color = "fuchsia",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Title = "Awesome Plastic Shirt"
                        },
                        new
                        {
                            Id = 18,
                            Color = "yellow",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Title = "Unbranded Frozen Towels"
                        },
                        new
                        {
                            Id = 19,
                            Color = "white",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Title = "Practical Granite Fish"
                        },
                        new
                        {
                            Id = 20,
                            Color = "maroon",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Title = "Intelligent Metal Table"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
