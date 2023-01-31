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
    [Migration("20230131100126_seedProducts")]
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

                    b.Property<string>("ImageUrl")
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
                            Id = 21,
                            Color = "tan",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            ImageUrl = "https://loremflickr.com/320/240?lock=1090134570",
                            Title = "Tasty Rubber Bacon"
                        },
                        new
                        {
                            Id = 22,
                            Color = "turquoise",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            ImageUrl = "https://loremflickr.com/320/240?lock=2630685",
                            Title = "Practical Soft Ball"
                        },
                        new
                        {
                            Id = 23,
                            Color = "cyan",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            ImageUrl = "https://loremflickr.com/320/240?lock=363444386",
                            Title = "Awesome Metal Soap"
                        },
                        new
                        {
                            Id = 24,
                            Color = "indigo",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            ImageUrl = "https://loremflickr.com/320/240?lock=47437810",
                            Title = "Handcrafted Cotton Soap"
                        },
                        new
                        {
                            Id = 25,
                            Color = "cyan",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            ImageUrl = "https://loremflickr.com/320/240?lock=853249890",
                            Title = "Intelligent Metal Ball"
                        },
                        new
                        {
                            Id = 26,
                            Color = "purple",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            ImageUrl = "https://loremflickr.com/320/240?lock=1472453055",
                            Title = "Fantastic Frozen Bike"
                        },
                        new
                        {
                            Id = 27,
                            Color = "magenta",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            ImageUrl = "https://loremflickr.com/320/240?lock=1032651746",
                            Title = "Sleek Steel Salad"
                        },
                        new
                        {
                            Id = 28,
                            Color = "plum",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            ImageUrl = "https://loremflickr.com/320/240?lock=1011612411",
                            Title = "Ergonomic Metal Shoes"
                        },
                        new
                        {
                            Id = 29,
                            Color = "mint green",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            ImageUrl = "https://loremflickr.com/320/240?lock=1443680306",
                            Title = "Handcrafted Soft Car"
                        },
                        new
                        {
                            Id = 30,
                            Color = "orange",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            ImageUrl = "https://loremflickr.com/320/240?lock=488923307",
                            Title = "Unbranded Metal Cheese"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}