﻿// <auto-generated />
using System;
using MicrogreensWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicrogreensWebsite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230527105130_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicrogreensWebsite.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryDescription = "Includes amaranth, beets, chard, quinoa, and spinach.",
                            CategoryName = "Amaranthaceae family"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryDescription = " Includes chives, garlic, leeks, and onions.",
                            CategoryName = "Amaryllidaceae family"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryDescription = " Includes carrot, celery, dill, and fennel.",
                            CategoryName = "Apiaceae family"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryDescription = "Includes chicory, endive, lettuce, and radicchio.",
                            CategoryName = "Asteraceae family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryDescription = "Includes arugula, broccoli, cabbage, cauliflower, radish, and watercress.",
                            CategoryName = "Brassicaceae family"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryDescription = " Includes cucumbers, melons, and squashes.",
                            CategoryName = "Cucurbitaceae family"
                        });
                });

            modelBuilder.Entity("MicrogreensWebsite.Models.Farmer", b =>
                {
                    b.Property<int>("FarmerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FarmerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarmerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarmerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmerID");

                    b.ToTable("Farmer");

                    b.HasData(
                        new
                        {
                            FarmerID = 1,
                            FarmerAddress = "Hillcrest",
                            FarmerEmail = "Mark@gmail.com",
                            FarmerName = "Mark Smith"
                        },
                        new
                        {
                            FarmerID = 2,
                            FarmerAddress = "Durban",
                            FarmerEmail = "Alida@gmail.com",
                            FarmerName = "Alida Bevis"
                        },
                        new
                        {
                            FarmerID = 3,
                            FarmerAddress = "Pinetown",
                            FarmerEmail = "John@gmail.com",
                            FarmerName = "John Joe"
                        });
                });

            modelBuilder.Entity("MicrogreensWebsite.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("FarmerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductSuppliedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("FarmerID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            FarmerID = 2,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 10.00m,
                            ProductDescription = "Spinach is a leafy green flowering plant native to central and western Asia.",
                            ProductImage = "~/images/spinach1.jpg",
                            ProductName = "Spinach",
                            ProductSuppliedDate = new DateTime(2016, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 20
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 2,
                            FarmerID = 3,
                            IsInStock = false,
                            IsOnSale = true,
                            Price = 80.00m,
                            ProductDescription = "Garlic is a species of bulbous flowering plant in the genus Allium",
                            ProductImage = "~/images/garlic1.jpg",
                            ProductName = "Garlic",
                            ProductSuppliedDate = new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 100
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 2,
                            FarmerID = 1,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 40.57m,
                            ProductDescription = "An onion is a vegetable that is the most widely cultivated species of the genus Allium.",
                            ProductImage = "~/images/Onion.jpg",
                            ProductName = "Onion",
                            ProductSuppliedDate = new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 20
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 6,
                            FarmerID = 2,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 20.56m,
                            ProductDescription = " Cucumbers are popular long, lean, and green garden vegetables. ",
                            ProductImage = "~/images/Cucumber1.jpg",
                            ProductName = "Cucumber",
                            ProductSuppliedDate = new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 80
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 4,
                            FarmerID = 3,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 15.87m,
                            ProductDescription = "Lettuce is an annual plant of the family Asteraceae. It is most often grown as a leaf vegetable",
                            ProductImage = "~/images/Lettuce1.jpg",
                            ProductName = "Lettuce",
                            ProductSuppliedDate = new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 70
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 3,
                            FarmerID = 2,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 20.87m,
                            ProductDescription = "Fennel is a flowering plant species in the carrot family",
                            ProductImage = "~/images/Fennel1.jpg",
                            ProductName = "Fennel",
                            ProductSuppliedDate = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 60
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 5,
                            FarmerID = 1,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 17.98m,
                            ProductDescription = "Broccoli is an edible green plant in the cabbage family",
                            ProductImage = "~/images/Broccoli1.jpg",
                            ProductName = "Broccoli",
                            ProductSuppliedDate = new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 80
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 5,
                            FarmerID = 3,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 9.99m,
                            ProductDescription = "Cauliflower is one of several vegetables in the species Brassica oleracea in the genus Brassica",
                            ProductImage = "~/images/Cauliflower1.jpg",
                            ProductName = "Cauliflower",
                            ProductSuppliedDate = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 100
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 6,
                            FarmerID = 1,
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 16.98m,
                            ProductDescription = " melon is any of various plants of the family Cucurbitaceae with sweet, edible, and fleshy fruit.",
                            ProductImage = "~/images/Melon.jpg",
                            ProductName = "Melons",
                            ProductSuppliedDate = new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 40
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MicrogreensWebsite.Models.Product", b =>
                {
                    b.HasOne("MicrogreensWebsite.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicrogreensWebsite.Models.Farmer", "Farmer")
                        .WithMany()
                        .HasForeignKey("FarmerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Farmer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
