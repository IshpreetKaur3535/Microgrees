using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public class CategoryRepository: ICategoryRepository
    {

        //  private readonly variable 
        private readonly AppDbContext _appDbContext;


        // default constructor
        public CategoryRepository()
        {
        }

        // constructor
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Category;

    }
}
