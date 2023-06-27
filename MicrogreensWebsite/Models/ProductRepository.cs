using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MicrogreensWebsite.Models
{
    public class ProductRepository : IProductRepository
    {
        // private readonly variable
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _appDbContext.Product.Include(p => p.Category).Include(f => f.Farmer);
            }
        }

        public IEnumerable<Product> GetProductOnSale
        {
            get
            {
               //same as above, but narrows it down to the ones on sale
                return _appDbContext.Product.Include(p => p.Category).Where(c => c.IsOnSale);

            }

        }

        public Product GetProductByID(int productID)
        {
            return _appDbContext.Product.FirstOrDefault(s => s.ProductID == productID ); //returns the first or default sweet ID. 
        }
    
    }


}

