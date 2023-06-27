using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts { get; }
        IEnumerable<Product> GetProductOnSale { get; }

        //how we going to fetch it by using ID
        Product GetProductByID(int ProductID);
    }
}
