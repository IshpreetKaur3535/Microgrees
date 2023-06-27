using System.Collections.Generic;

namespace MicrogreensWebsite.Models
{
    public class FarmerRepository: IFarmerRepository
    {
        //private readonly varible 
        private readonly AppDbContext _appDbContext;

        //default cnstructor
        public FarmerRepository()
        {
        }

        //constructor
        public FarmerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       

        public IEnumerable<Farmer> GetAllFarmers => _appDbContext.Farmer;

    }
}
