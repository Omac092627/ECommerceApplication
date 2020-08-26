﻿// <auto-generated />
using System;
using ECommerce_Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce_Application.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce_Application.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ECommerce_Application.Models.CartItem", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ECommerce_Application.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ECommerce_Application.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeature")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperPower")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            Breed = "Staffordshire Terrier",
                            Category = "Bully",
                            Color = "Brindle",
                            Description = "Absolutely is an attention hog. He will chill and hang out with you all day and love life. He enjoys the outdoors from sunbathing in the backyard to going for long walks. Is very obedient and will let you clean his ears, brush ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Rampage",
                            IsFeature = true,
                            Name = "Rampage",
                            Price = 200m,
                            Quantity = 1,
                            SuperPower = "Super Love"
                        },
                        new
                        {
                            Id = 2,
                            Age = 4,
                            Breed = "Poodle",
                            Category = "Poodles",
                            Color = "White",
                            Description = "Loves ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Snowball",
                            IsFeature = false,
                            Name = "Snowball",
                            Price = 200m,
                            Quantity = 1,
                            SuperPower = "Super Love"
                        },
                        new
                        {
                            Id = 3,
                            Age = 7,
                            Breed = "Golden Doodle",
                            Category = "Poodles",
                            Color = "Golden",
                            Description = "Her thick hips won't stop her from dragging you across the concrete to catch a squirrel",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Whiskey",
                            IsFeature = false,
                            Name = "Whiskey",
                            Price = 2000m,
                            Quantity = 1,
                            SuperPower = "Fly"
                        },
                        new
                        {
                            Id = 4,
                            Age = 6,
                            Breed = "Labradoodle",
                            Category = "Poodles",
                            Color = "black",
                            Description = "Fastest dog in the world. She's beat Usain Bolt... Twice. ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/rye.jpeg",
                            IsFeature = false,
                            Name = "Rye",
                            Price = 9000m,
                            Quantity = 1,
                            SuperPower = "Super speed"
                        },
                        new
                        {
                            Id = 5,
                            Age = 3,
                            Breed = "Dog",
                            Category = "Poodles",
                            Color = "Brown and White",
                            Description = "Will knock anything on your desk onto the floor. Can also poop in toilet. ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/backup.jpeg",
                            IsFeature = false,
                            Name = "Snowball",
                            Price = 4000m,
                            Quantity = 1,
                            SuperPower = "Personality"
                        },
                        new
                        {
                            Id = 6,
                            Age = 15,
                            Breed = "Dog",
                            Category = "Bully",
                            Color = "Brown",
                            Description = "Speaks English... And a little Spanish. ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Duke1.jpeg",
                            IsFeature = false,
                            Name = "Duke",
                            Price = 9000m,
                            Quantity = 1,
                            SuperPower = "Speaking"
                        },
                        new
                        {
                            Id = 7,
                            Age = 99,
                            Breed = "Dog",
                            Category = "Bully",
                            Color = "Grey",
                            Description = "Disrupts Zoom meetings. Can order Starbucks on occassion.",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Josie",
                            IsFeature = false,
                            Name = "Josie",
                            Price = 6000m,
                            Quantity = 1,
                            SuperPower = "Ordering coffee"
                        },
                        new
                        {
                            Id = 8,
                            Age = 8,
                            Breed = "Dog",
                            Category = "Bully",
                            Color = "Orangeish",
                            Description = "As if a dog wasn't enough, this guy comes with laser eyes. ",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/chubbs.jpeg",
                            IsFeature = false,
                            Name = "Chubbs",
                            Price = 1000m,
                            Quantity = 1,
                            SuperPower = "Laser Eyes"
                        },
                        new
                        {
                            Id = 9,
                            Age = 15,
                            Breed = "Dog",
                            Category = "Bully",
                            Color = "Orange and White",
                            Description = "An engineer who dabbles in explosives.",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Peanut.jpeg",
                            IsFeature = false,
                            Name = "Peanut",
                            Price = 5000m,
                            Quantity = 1,
                            SuperPower = "Super Genius"
                        },
                        new
                        {
                            Id = 10,
                            Age = 6,
                            Breed = "Pomeranian",
                            Category = "Mixed",
                            Color = "Black",
                            Description = "Makes bukoo money.",
                            Image = "https://superpetpicturestorage.blob.core.windows.net/productimages/Mani",
                            IsFeature = false,
                            Name = "Mani",
                            Price = 1000m,
                            Quantity = 1,
                            SuperPower = "Can produce cash out of thin-air"
                        });
                });

            modelBuilder.Entity("ECommerce_Application.Models.CartItem", b =>
                {
                    b.HasOne("ECommerce_Application.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_Application.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce_Application.Models.Order", b =>
                {
                    b.HasOne("ECommerce_Application.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
