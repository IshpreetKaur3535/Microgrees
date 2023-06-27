using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public interface IFarmerRepository
    {
        IEnumerable<Farmer> GetAllFarmers { get; }
    }
}
