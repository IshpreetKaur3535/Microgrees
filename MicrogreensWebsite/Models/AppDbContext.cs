using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace MicrogreensWebsite.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) :

            base(options)
        {
        }


      
        public DbSet<Product> Product { get; set; }
  
        public DbSet<Category> Category { get; set; }

        public DbSet<Farmer> Farmer { get; set;  }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // now the dummy data --> to pace into db

            // seeding the category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Amaranthaceae family", CategoryDescription = "Includes amaranth, beets, chard, quinoa, and spinach." },
                new Category { CategoryID = 2, CategoryName = "Amaryllidaceae family", CategoryDescription = " Includes chives, garlic, leeks, and onions." },
                new Category { CategoryID = 3, CategoryName = "Apiaceae family", CategoryDescription = " Includes carrot, celery, dill, and fennel." },
                new Category { CategoryID = 4, CategoryName = "Asteraceae family", CategoryDescription = "Includes chicory, endive, lettuce, and radicchio." },
                new Category { CategoryID = 5, CategoryName = "Brassicaceae family", CategoryDescription = "Includes arugula, broccoli, cabbage, cauliflower, radish, and watercress." },
                new Category { CategoryID = 6, CategoryName = "Cucurbitaceae family", CategoryDescription = " Includes cucumbers, melons, and squashes." });

            //seeding the farmer
            modelBuilder.Entity<Farmer>().HasData(
               new Farmer { FarmerID = 1, FarmerName = "Mark Smith", FarmerEmail = "Mark@gmail.com", FarmerAddress = "Hillcrest" },
               new Farmer { FarmerID = 2, FarmerName = "Alida Bevis", FarmerEmail = "Alida@gmail.com", FarmerAddress = "Durban" },
               new Farmer { FarmerID = 3, FarmerName = "John Joe", FarmerEmail = "John@gmail.com", FarmerAddress = "Pinetown" });


            //seeding the products
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  ProductID = 1,
                  ProductName = "Spinach",
                  ProductDescription = "Spinach is a leafy green flowering plant native to central and western Asia.",
                  ProductImage = "~/images/spinach1.jpg",
                  ProductSuppliedDate = DateTime.Parse("2016-05-02"),
                  CategoryID = 1,
                  FarmerID = 2,
                  Quantity = 20,
                  Price = 10.00M,
                  IsOnSale = false,
                  IsInStock = true

              },

              new Product
              {
                  ProductID = 2,
                  ProductName = "Garlic",
                  ProductDescription = "Garlic is a species of bulbous flowering plant in the genus Allium",
                  ProductImage = "~/images/garlic1.jpg",
                  ProductSuppliedDate = DateTime.Parse("2023-05-21"),
                  CategoryID = 2,
                  FarmerID = 3,
                  Quantity = 100,
                  Price = 80.00M,
                  IsOnSale = true,
                  IsInStock = false

              },

               new Product
               {
                   ProductID = 3,
                   ProductName = "Onion",
                   ProductDescription = "An onion is a vegetable that is the most widely cultivated species of the genus Allium.",
                   ProductImage = "~/images/Onion.jpg",
                   ProductSuppliedDate = DateTime.Parse("2023-05-24"),
                   CategoryID = 2,
                   FarmerID = 1,
                   Quantity = 20,
                   Price = 40.57M,
                   IsOnSale = false,
                   IsInStock = true

               },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Cucumber",
                    ProductDescription = " Cucumbers are popular long, lean, and green garden vegetables. ",
                    ProductImage = "~/images/Cucumber1.jpg",
                    ProductSuppliedDate = DateTime.Parse("2023-05-24"),
                    CategoryID = 6,
                    FarmerID = 2,
                    Quantity = 80,
                    Price = 20.56M,
                    IsOnSale = false,
                    IsInStock = true

                },

                 new Product
                 {
                     ProductID = 5,
                     ProductName = "Lettuce",
                     ProductDescription = "Lettuce is an annual plant of the family Asteraceae. It is most often grown as a leaf vegetable",
                     ProductImage = "~/images/Lettuce1.jpg",
                     ProductSuppliedDate = DateTime.Parse("2023-05-23"),
                     CategoryID = 4,
                     FarmerID = 3,
                     Quantity = 70,
                     Price = 15.87M,
                     IsOnSale = false,
                     IsInStock = true

                 },

                  new Product
                  {
                      ProductID = 6,
                      ProductName = "Fennel",
                      ProductDescription = "Fennel is a flowering plant species in the carrot family",
                      ProductImage = "~/images/Fennel1.jpg",
                      ProductSuppliedDate = DateTime.Parse("2023-05-22"),
                      CategoryID = 3,
                      FarmerID = 2,
                      Quantity = 60,
                      Price = 20.87M,
                      IsOnSale = false,
                      IsInStock = true

                  },
                   new Product
                   {
                       ProductID = 7,
                       ProductName = "Broccoli",
                       ProductDescription = "Broccoli is an edible green plant in the cabbage family",
                       ProductImage = "~/images/Broccoli1.jpg",
                       ProductSuppliedDate = DateTime.Parse("2023-05-23"),
                       CategoryID = 5,
                       FarmerID = 1,
                       Quantity = 80,
                       Price = 17.98M,
                       IsOnSale = false,
                       IsInStock = true

                   },

                    new Product
                    {
                        ProductID = 8,
                        ProductName = "Cauliflower",
                        ProductDescription = "Cauliflower is one of several vegetables in the species Brassica oleracea in the genus Brassica",
                        ProductImage = "~/images/Cauliflower1.jpg",
                        ProductSuppliedDate = DateTime.Parse("2023-05-22"),
                        CategoryID = 5,
                        FarmerID = 3,
                        Quantity = 100,
                        Price = 9.99M,
                        IsOnSale = false,
                        IsInStock = true

                    },
                     new Product
                     {
                         ProductID = 9,
                         ProductName = "Melons",
                         ProductDescription = " melon is any of various plants of the family Cucurbitaceae with sweet, edible, and fleshy fruit.",
                         ProductImage = "~/images/Melon.jpg",
                         ProductSuppliedDate = DateTime.Parse("2023-05-23"),
                         CategoryID = 6,
                         FarmerID = 1,
                         Quantity = 40,
                         Price = 16.98M,
                         IsOnSale = false,
                         IsInStock = true

                     });



        }
    }
    }
