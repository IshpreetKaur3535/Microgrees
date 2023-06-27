using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

    }
}
