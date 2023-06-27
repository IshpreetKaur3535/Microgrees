using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public class Product 
    {


        //varibale to store the product id in the database
        public int ProductID { get; set; }

        //variable to store the product name in the database
        public string ProductName { get; set; }

        // variable to store the product description in the database
        public string ProductDescription { get; set; }

        //varibale to store the image of the product in the database
        public string ProductImage { get; set; }

        //varibale to store the supplied date of the product in the database
        public DateTime ProductSuppliedDate { get; set; }

        //varibale to store the farmer id in the database to check which farmer the product belongs to 
        public int FarmerID { get; set; }

        //varibale to store the category id in the database to check which category does the product fall under
        public int CategoryID { get; set; }

        //varibale to store the quantity of the product in the database
        public int Quantity { get; set; }

        //varibale to store the price of the product in the database
        public decimal Price { get; set; }

        ////varibale to check whether the stock is available or not
        public Boolean IsInStock { get; set; }

        // variabke to check whether the stock is on sale or not
        public Boolean IsOnSale { get; set; }

        public Category Category { get; set; }
        public Farmer Farmer { get; set; }
       


    }
}


